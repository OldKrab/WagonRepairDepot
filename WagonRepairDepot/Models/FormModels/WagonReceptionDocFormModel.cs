using System.Collections.Generic;
using System.Linq;

namespace WagonRepairDepot.Models
{
    class WagonReceptionDocFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }
        public IFieldModel Identificator { get; private set; }
        public WagonReceptionDocFormModel()
        {
            var context = new Contexts.TrainContext();
            FieldModels = new List<IFieldModel>();
            FieldModels.Add(Identificator = new HiddenFieldModel("ID"));
            FieldModels.Add(new DateFieldModel("Дата создания"));
            FieldModels.Add(new StringFieldModel("Название"));
            FieldModels.Add(new DateFieldModel("Дата приема"));
            FieldModels.Add(new DateFieldModel("Примерная дата завершения ремонта"));
            FieldModels.Add(new StringFieldModel("Дефект"));


            FieldModels.Add(new IndexFieldModel("Вагон",
                context.Wagons.Select(a => a.WagonId),
                context.Wagons.Select(s => s.ToString())
                ));

            FieldModels.Add(new IndexFieldModel("Клиент",
                context.Clients.Select(a => a.ClientId),
                context.Clients.Select(s => s.ToString())
                ));

            FieldModels.Add(new IndexFieldModel("Осмоторщик",
                context.Inspectors.Select(a => a.InspectorId),
                context.Inspectors.Select(s => s.ToString())
                ));
        }
    }

}
