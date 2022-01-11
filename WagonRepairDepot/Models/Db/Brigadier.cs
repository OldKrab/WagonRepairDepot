using System;
using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Brigadier
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DisplayName("ID")]
        public int BrigadierId { get; set; }

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

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DisplayName("Пол")]
        public bool Sex { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Brigade> Brigades { get; set; } = new HashSet<Brigade>();

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();

        public override string ToString()
        {
            return $"{Surname} {Name}" + (Middlename == null ? "" : $" {Middlename}");
        }
    }
}
