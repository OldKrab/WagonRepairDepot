using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Brigade
    {
        public int BrigadeId { get; set; }
        public int BrigadierId { get; set; }

        public virtual Brigadier Brigadier { get; set; } = null!;
        public virtual ICollection<WorkerBrigade> WorkerBrigades { get; set; } = new HashSet<WorkerBrigade>();
        public virtual ICollection<Work> Works { get; set; } = new HashSet<Work>();
    }
}
