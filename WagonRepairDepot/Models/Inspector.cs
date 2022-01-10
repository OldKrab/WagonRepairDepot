using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Inspector
    {
        public int InspectorId { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Middlename { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public bool Sex { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new HashSet<WorkOrder>();
    }
}
