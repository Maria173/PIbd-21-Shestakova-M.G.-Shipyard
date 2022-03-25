using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardBusinessLogic.OfficePackage.HelperEnums;
using ShipyardBusinessLogic.OfficePackage.HelperModels;

namespace ShipyardBusinessLogic.OfficePackage
{
    public abstract class AbstractSaveToWord
    {
        public void CreateDoc(WordInfo info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> { (info.Title, new
WordTextProperties { Bold = true, Size = "24", }) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            foreach (var ship in info.Ships)
            {
                CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> {
                        (ship.ShipName + ": ", new WordTextProperties {
                            Size = "24", Bold = true}),
                        (Convert.ToInt32(ship.Price).ToString(), new WordTextProperties {
                        Size = "24"
                        })
                    },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationType = WordJustificationType.Both
                    }
                });
            }
            SaveWord(info);
        }

        // Создание doc-файла
        protected abstract void CreateWord(WordInfo info);

        // Создание абзаца с текстом
        protected abstract void CreateParagraph(WordParagraph paragraph);

        // Сохранение файла
        protected abstract void SaveWord(WordInfo info);

    }
}