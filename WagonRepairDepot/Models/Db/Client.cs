using System.Collections.Generic;

namespace WagonRepairDepot.Models
{
    public class Client
    {
        [System.ComponentModel.Browsable(false)]
        public int ClientId { get; set; }
        
        [System.ComponentModel.DisplayName("Фамилия")]
        public string Surname { get; set; } = null!;

        [System.ComponentModel.DisplayName("Имя")]
        public string Name { get; set; } = null!;

        [System.ComponentModel.DisplayName("Отчество")]
        public string? Middlename { get; set; }

        [System.ComponentModel.DisplayName("Пол")]
        public string SexString => Sex ? "Мужской" : "Женский";

        [System.ComponentModel.Browsable(false)]
        public bool Sex { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<WagonReturnDoc> WagonReturnDocs { get; set; } = new HashSet<WagonReturnDoc>();
    }
}
