using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Brigade
    {

        [System.ComponentModel.Browsable(false)]
        public int BrigadeId { get; set; }

        [System.ComponentModel.DisplayName("Бригадир")]
        public string BrigadierFIO => Brigadier.ToString();
        
        [System.ComponentModel.Browsable(false)]
        public int BrigadierId { get; set; }
        
        [System.ComponentModel.Browsable(false)]
        public virtual Brigadier Brigadier { get; set; } = null!;
        
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WorkerBrigade> WorkerBrigades { get; set; } = new HashSet<WorkerBrigade>();
        
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Work> Works { get; set; } = new HashSet<Work>();
    }
}
