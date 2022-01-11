using System;

namespace WagonRepairDepot.Models
{
    public class WagonReturnDoc
    {
        [System.ComponentModel.Browsable(false)]
        public int ReturnDocId { get; set; }

        [System.ComponentModel.DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }
        
        [System.ComponentModel.DisplayName("Название")]
        public string Name { get; set; } = null!;

        [System.ComponentModel.DisplayName("Дата выдачи")]
        public DateTime ReturnDate { get; set; }
        
        [System.ComponentModel.DisplayName("Серийный номер вагона")]
        public string WagonSerialNumber => Wagon.SerialNumber;

        [System.ComponentModel.Browsable(false)]
        public int WagonId { get; set; }
        
        [System.ComponentModel.Browsable(false)]
        public int ClientId { get; set; }
        
        [System.ComponentModel.Browsable(false)]
        public int BrigadierId { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Brigadier Brigadier { get; set; } = null!;
        
        [System.ComponentModel.Browsable(false)]
        public virtual Client Client { get; set; } = null!;
        
        [System.ComponentModel.Browsable(false)]
        public virtual Wagon Wagon { get; set; } = null!;
    }
}
