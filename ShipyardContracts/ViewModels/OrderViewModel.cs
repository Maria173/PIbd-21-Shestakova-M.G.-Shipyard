﻿using ShipyardContracts.Enums;
using System;
using ShipyardContracts.Attributes;
using System.Runtime.Serialization;


namespace ShipyardContracts.ViewModels
{
    public class OrderViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }

        public int ShipId { get; set; }
        public int ClientId { get; set; }
        public int? ImplementerId { get; set; }

        [Column(title: "Клиент", width: 150)]
        public string ClientFCs { get; set; }

        [Column(title: "Изделие", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ShipName { get; set; }

        [Column(title: "Количество", width: 100)]
        public int Count { get; set; }

        [Column(title: "Сумма", width: 50)]
        public decimal Sum { get; set; }

        [Column(title: "Исполнитель", width: 150)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Статус", width: 100)]
        public OrderStatus Status { get; set; }

        [Column(title: "Дата создания", width: 100)]
        public DateTime DateCreate { get; set; }

        [Column(title: "Дата выполнения", width: 100)]
        public DateTime? DateImplement { get; set; }
    }
}
