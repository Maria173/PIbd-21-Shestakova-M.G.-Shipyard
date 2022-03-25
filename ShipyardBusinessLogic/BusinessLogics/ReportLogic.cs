using ShipyardBusinessLogic.OfficePackage;
using ShipyardBusinessLogic.OfficePackage.HelperModels;
using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using ShipyardContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShipyardBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IComponentStorage _componentStorage;
        private readonly IShipStorage _shipStorage;
        private readonly IOrderStorage _orderStorage;
        private readonly AbstractSaveToExcel _saveToExcel;
        private readonly AbstractSaveToWord _saveToWord;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IShipStorage shipStorage, IComponentStorage
       componentStorage, IOrderStorage orderStorage,
        AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord,
       AbstractSaveToPdf saveToPdf)
        {
            _shipStorage = shipStorage;
            _componentStorage = componentStorage;
            _orderStorage = orderStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }

        // Получение списка компонент с указанием, в каких изделиях используются
        public List<ReportShipComponentViewModel> GetShipComponent()
        {
            var ships = _shipStorage.GetFullList();
            var list = new List<ReportShipComponentViewModel>();
            foreach (var ship in ships)
            {
                var record = new ReportShipComponentViewModel
                {
                    ShipName = ship.ShipName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var shp in ship.ShipComponents)
                {
                    record.Components.Add(new Tuple<string, int>(shp.Value.Item1, shp.Value.Item2));
                    record.TotalCount += shp.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        // Получение списка заказов за определенный период
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                ShipName = x.ShipName,
                Count = x.Count,
                Sum = x.Sum,
                Status = Enum.GetName(typeof(OrderStatus), x.Status)
            })
           .ToList();
        }

        // Сохранение компонент в файл-Word
        public void SaveComponentsToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                Ships = _shipStorage.GetFullList()
            });
        }

        // Сохранение компонент с указаеним продуктов в файл-Excel
        public void SaveShipComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список компонент",
                ShipComponents = GetShipComponent()
            });
        }

        // Сохранение заказов в файл-Pdf
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
    }
}