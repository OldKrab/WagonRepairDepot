using System;

namespace WagonRepairDepot.Models
{
    public class ActualWorkOrder
    {
        public int? WorkOrderId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Name { get; set; }
        public int? InspectorId { get; set; }
        public int? WagonId { get; set; }
    }
}
