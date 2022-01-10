using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Middlename { get; set; }
        public bool Sex { get; set; }

        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();
    }
}
