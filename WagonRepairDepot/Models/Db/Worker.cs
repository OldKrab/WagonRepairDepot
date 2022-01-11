using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Worker
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DisplayName("ID")]
        public int WorkerId { get; set; }

        [System.ComponentModel.DisplayName("Фамилия")]
        public string Surname { get; set; } = null!;

        [System.ComponentModel.DisplayName("Имя")]
        public string Name { get; set; } = null!;

        [System.ComponentModel.DisplayName("Отчество")]
        public string? Middlename { get; set; }

        [System.ComponentModel.DisplayName("Дата найма")]
        public DateTime HiringDate { get; set; }

        [System.ComponentModel.DisplayName("Дата увольнения")]
        public DateTime? DismissalDate { get; set; }

        [System.ComponentModel.DisplayName("Пол ")]
        public string SexString => Sex ? "Мужской" : "Женский";

        [System.ComponentModel.DisplayName("Пол")]
        [System.ComponentModel.Browsable(false)]
        public bool Sex { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WorkerBrigade> WorkerBrigades { get; set; } = new HashSet<WorkerBrigade>();

        public override string ToString()
        {
            return $"{Surname} {Name}" + (Middlename == null ? "" : $" {Middlename}");
        }
    }
}
