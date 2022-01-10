using System;

namespace WagonRepairDepot.Models
{
    public class Work
    {
        public int WorkId { get; set; }
        public DateTime PlannedDeadline { get; set; }
        public DateTime? ActualDeadline { get; set; }
        public int BrigadeId { get; set; }
        public int WorkTypeId { get; set; }
        public int WorkOrderId { get; set; }

        public virtual Brigade Brigade { get; set; } = null!;
        public virtual WorkOrder WorkOrder { get; set; } = null!;
        public virtual WorkType WorkType { get; set; } = null!;
    }
}
