using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WagonRepairDepot.Models
{
    public interface IFormModel
    {
        public IFieldModel Identificator { get; }
        public List<IFieldModel> FieldModels { get; }


    }

}
