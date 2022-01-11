using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    class WagonFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }
        public IFieldModel Identificator { get; private set; }
        public WagonFormModel()
        {
            FieldModels = new List<IFieldModel>();
            FieldModels.Add(Identificator = new HiddenFieldModel("ID"));
            FieldModels.Add(new StringFieldModel("Модель"));
            FieldModels.Add(new StringFieldModel("Тип"));
            FieldModels.Add(new IntFieldModel("Количество сидений"));
            FieldModels.Add(new DateFieldModel("Год создания"));
            FieldModels.Add(new StringFieldModel("Серийный номер"));
        }
    }

}
