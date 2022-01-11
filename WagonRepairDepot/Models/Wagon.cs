using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Wagon
    {
        public int WagonId { get; set; }
        public string Model { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int SeatsNumber { get; set; }
        public DateTime CreationYear { get; set; }
        public string SerialNumber { get; set; } = null!;

        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();
        public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new HashSet<WorkOrder>();
    }
}
