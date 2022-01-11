using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class WorkType
    {
        public int WorkTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Work> Works { get; set; } = new HashSet<Work>();
    }
}
