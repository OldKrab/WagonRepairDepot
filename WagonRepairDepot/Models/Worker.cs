using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Middlename { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public bool Sex { get; set; }

        public virtual ICollection<WorkerBrigade> WorkerBrigades { get; set; } = new HashSet<WorkerBrigade>();
    }
}
