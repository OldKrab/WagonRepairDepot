using System;

namespace WagonRepairDepot.Models
{
    public class Work
    {
        [System.ComponentModel.DisplayName("ID")]

        [System.ComponentModel.Browsable(false)]
        public int WorkId { get; set; }

        [System.ComponentModel.DisplayName("Планируемая дата завершения")]
        public DateTime PlannedDeadline { get; set; }

        [System.ComponentModel.DisplayName("Реальная дата завершения")]
        public DateTime? ActualDeadline { get; set; }

        [System.ComponentModel.DisplayName("Тип ")]
        public string WorkTypeString => WorkType.Name;

        [System.ComponentModel.DisplayName("Серийный номер вагона")]
        public string WagonSerialNumber => WorkOrder.Wagon.SerialNumber;

        [System.ComponentModel.DisplayName("Бригадир")]
        [System.ComponentModel.Browsable(false)]
        public int BrigadeId { get; set; }

        [System.ComponentModel.DisplayName("Тип")]
        [System.ComponentModel.Browsable(false)]
        public int WorkTypeId { get; set; }

        [System.ComponentModel.DisplayName("Заказ-наряд")]
        [System.ComponentModel.Browsable(false)]
        public int WorkOrderId { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Brigade Brigade { get; set; } = null!;

        [System.ComponentModel.Browsable(false)]
        public virtual WorkOrder WorkOrder { get; set; } = null!;

        [System.ComponentModel.Browsable(false)]
        public virtual WorkType WorkType { get; set; } = null!;
    }
}
