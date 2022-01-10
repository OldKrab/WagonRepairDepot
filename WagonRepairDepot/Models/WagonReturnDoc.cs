using System;

namespace WagonRepairDepot.Models
{
    public class WagonReturnDoc
    {
        public int ReturnDocId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; } = null!;
        public DateTime ReturnDate { get; set; }
        public int WagonId { get; set; }
        public int ClientId { get; set; }
        public int BrigadierId { get; set; }

        public virtual Brigadier Brigadier { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Wagon Wagon { get; set; } = null!;
    }
}
