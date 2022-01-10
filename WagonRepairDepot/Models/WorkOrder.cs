using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; } = null!;
        public int InspectorId { get; set; }
        public int WagonId { get; set; }

        public virtual Inspector Inspector { get; set; } = null!;
        public virtual Wagon Wagon { get; set; } = null!;
        public virtual ICollection<Work> Works { get; set; } = new HashSet<Work>();
    }
}
