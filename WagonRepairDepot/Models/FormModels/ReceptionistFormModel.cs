using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    class ReceptionistFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }
        public IFieldModel Identificator { get; private set; }
        public ReceptionistFormModel()
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
