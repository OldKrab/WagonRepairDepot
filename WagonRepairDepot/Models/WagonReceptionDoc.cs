using System;

namespace WagonRepairDepot.Models
{
    public class WagonReceptionDoc
    {
        public int RecDocId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; } = null!;
        public DateTime ReceptionDate { get; set; }
        public DateTime ApproxRepairDate { get; set; }
        public string Defect { get; set; } = null!;
        public int WagonId { get; set; }
        public int ClientId { get; set; }
        public int ReceptionistId { get; set; }
    }
}
