using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Wagon
    {
        [System.ComponentModel.Browsable(false)]
        public int WagonId { get; set; }
        
        [System.ComponentModel.DisplayName("Модель")]
        public string Model { get; set; } = null!;
        
        [System.ComponentModel.DisplayName("Тип")]
        public string Type { get; set; } = null!;
        
        [System.ComponentModel.DisplayName("Количество сидений")]
        public long SeatsNumber { get; set; }
        
        [System.ComponentModel.DisplayName("Год создания")]
        public DateTime CreationYear { get; set; }
        
        [System.ComponentModel.DisplayName("Серийный номер")]
        public string SerialNumber { get; set; } = null!;

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();
       
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new HashSet<WorkOrder>();
    }
}
