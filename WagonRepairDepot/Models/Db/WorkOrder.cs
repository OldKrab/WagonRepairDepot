using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class WorkOrder
    {
        [System.ComponentModel.Browsable(false)]
        public int WorkOrderId { get; set; }

        [System.ComponentModel.DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }

        [System.ComponentModel.DisplayName("Название")]
        public string Name { get; set; } = null!;

        [System.ComponentModel.DisplayName("Серийный номер вагона")]
        public string WagonSerialNumber => Wagon.SerialNumber;

        [System.ComponentModel.Browsable(false)]
        public int InspectorId { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int WagonId { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Inspector Inspector { get; set; } = null!;

        [System.ComponentModel.Browsable(false)]
        public virtual Wagon Wagon { get; set; } = null!;

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Work> Works { get; set; } = new HashSet<Work>();
    }
}
