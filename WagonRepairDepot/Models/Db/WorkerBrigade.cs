namespace WagonRepairDepot.Models
{
    public class WorkerBrigade
    {
        public int WorkerBrigadeId { get; set; }
        public int WorkerId { get; set; }
        public int BrigadeId { get; set; }

        public virtual Brigade Brigade { get; set; } = null!;
        public virtual Worker Worker { get; set; } = null!;
    }
}
