using System;

namespace WagonRepairDepot.Models
{
    public class Receptionist
    {
        [System.ComponentModel.Browsable(false)]
        public int ReceptionistId { get; set; }

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

        [System.ComponentModel.DisplayName("Пол")]
        public string SexString => Sex ? "Мужской" : "Женский";

        [System.ComponentModel.Browsable(false)]
        public bool Sex { get; set; }
    }
}
