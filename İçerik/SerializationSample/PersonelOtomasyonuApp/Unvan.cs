using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyonuApp
{
    public enum Unvan
    {
        [Display(Name ="Müdür")]

        Mudur,
        [Display(Name = "Yönetici")]
        Yonetici,
        CEO,
        [Display(Name = "Temizlik Personeli")]
        TemizlikPersoneli,
        [Display(Name = "Danışman")]
        Danisman,
        [Display(Name = "Müşteri Yöneticis")]
        MusteriYoneticisi,
        [Display(Name = "Eğitmen")]
        Egitmen,
        Belirtilmedi
    }
}
