using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonRepairDepot.Models
{
    public interface IFormModel
    {
        public List<IFieldModel> FieldModels { get; }
    }


    class BrigadirFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }

        public BrigadirFormModel()
        {
            FieldModels = new List<IFieldModel>();

            FieldModels.Append(new HiddenFieldModel());
            FieldModels.Append(new StringFieldModel("Фамилия"));
            FieldModels.Append(new StringFieldModel("Имя"));
            FieldModels.Append(new StringFieldModel("Отчество"));
            FieldModels.Append(new DateFieldModel("Дата найма"));
            FieldModels.Append(new DateFieldModel("Дата увольнения"));
        }
    }


    class BrigadeFormModel : IFormModel
    {
        public List<IFieldModel> FieldModels { get; private set; }

        public BrigadeFormModel()
        {
            Contexts.TrainContext context = new ();
            FieldModels = new List<IFieldModel>();

            FieldModels.Add(new HiddenFieldModel());
            FieldModels.Add(new IndexFieldModel(
                    "Бригадир",
                    context.Brigadiers.Select(a => a.BrigadierId),
                    context.Brigadiers.Select(a => a.Surname)
                )
            );
        }
    }

}
