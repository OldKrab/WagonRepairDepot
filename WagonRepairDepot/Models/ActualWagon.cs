using System;

namespace WagonRepairDepot.Models
{
    public class ActualWagon
    {
        public int? WagonId { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public long? SeatsNumber { get; set; }
        public DateTime? CreationYear { get; set; }
        public string? SerialNumber { get; set; }
    }
}
