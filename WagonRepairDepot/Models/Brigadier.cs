using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Brigadier
    {
        public int BrigadierId { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Middlename { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public bool Sex { get; set; }

        public virtual ICollection<Brigade> Brigades { get; set; } = new HashSet<Brigade>();
        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();
    }
}
