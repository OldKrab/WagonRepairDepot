using System.Collections.Generic;
using System.Linq;

namespace WagonRepairDepot.Models
{
    class WorkFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }
        public IFieldModel Identificator { get; private set; }
        public WorkFormModel()
        {
            var context = new Contexts.TrainContext();
            FieldModels = new List<IFieldModel>();
            FieldModels.Add(Identificator = new HiddenFieldModel("ID"));
            FieldModels.Add(new DateFieldModel("Планируемая дата завершения"));

            FieldModels.Add(new IndexFieldModel("Тип",
                context.Wagons.Select(a => a.WagonId),
                context.Wagons.Select(s => s.ToString())
                ));

            FieldModels.Add(new IndexFieldModel("Бригадир",
                context.Brigadiers.Select(a => a.BrigadierId),
                context.Brigadiers.Select(s => s.ToString())
                ));

            FieldModels.Add(new IndexFieldModel("Заказ-наряд",
             context.WorkOrders.Select(a => a.WorkOrderId),
             context.WorkOrders.Select(s => s.ToString())
             ));
        }
    }

}
