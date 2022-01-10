using System;

namespace WagonRepairDepot.Models
{
    public class ActualWork
    {
        public int? WorkId { get; set; }
        public DateTime? PlannedDeadline { get; set; }
        public DateTime? ActualDeadline { get; set; }
        public int? BrigadeId { get; set; }
        public int? WorkTypeId { get; set; }
        public int? WorkOrderId { get; set; }
    }
}
