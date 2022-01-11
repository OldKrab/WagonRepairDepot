using System;

namespace WagonRepairDepot.Models
{
    public class WagonReceptionDoc
    {
        [System.ComponentModel.DisplayName("ID")]
        [System.ComponentModel.Browsable(false)]
        public int RecDocId { get; set; }

        [System.ComponentModel.DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }

        [System.ComponentModel.DisplayName("Название")]
        public string Name { get; set; } = null!;

        [System.ComponentModel.DisplayName("Дата приема")]
        public DateTime ReceptionDate { get; set; }

        [System.ComponentModel.DisplayName("Примерная дата завершения ремонта")]
        public DateTime ApproxRepairDate { get; set; }

        [System.ComponentModel.DisplayName("Дефект")]
        public string Defect { get; set; } = null!;

        [System.ComponentModel.DisplayName("Серийный номер вагона")]
        public string WagonSerialNumber => Wagon.SerialNumber;

        [System.ComponentModel.DisplayName("Вагон")]
        [System.ComponentModel.Browsable(false)]
        public int WagonId { get; set; }

        [System.ComponentModel.DisplayName("Клиент")]
        [System.ComponentModel.Browsable(false)]
        public int ClientId { get; set; }

        [System.ComponentModel.DisplayName("Осмоторщик")]
        [System.ComponentModel.Browsable(false)]
        public int ReceptionistId { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Receptionist Receptionist { get; set; } = null!;
        
        [System.ComponentModel.Browsable(false)]
        public virtual Client Client { get; set; } = null!;
        
        [System.ComponentModel.Browsable(false)]
        public virtual Wagon Wagon { get; set; } = null!;
    }
}
