using System;

namespace WagonRepairDepot.Models
{
    public class Receptionist
    {
        public int ReceptionistId { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Middlename { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public bool Sex { get; set; }
    }
}
