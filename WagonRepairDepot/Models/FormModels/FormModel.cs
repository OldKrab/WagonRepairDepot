using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonRepairDepot.Models
{
    public interface IFormModel
    {
        public IFieldModel Identificator { get; }
        public List<IFieldModel> FieldModels { get; }


    }


    class BrigadierFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }

        public IFieldModel Identificator { get; private set; }

        public BrigadierFormModel()
        {
            FieldModels = new List<IFieldModel>();
            FieldModels.Add(Identificator = new HiddenFieldModel("ID"));
            FieldModels.Add(new StringFieldModel("Фамилия"));
            FieldModels.Add(new StringFieldModel("Имя"));
            FieldModels.Add(new StringFieldModel("Отчество"));
            FieldModels.Add(new DateFieldModel("Дата найма"));
            FieldModels.Add(new BoolFieldModel("Пол", "М", "Ж"));
        }
    }
}
