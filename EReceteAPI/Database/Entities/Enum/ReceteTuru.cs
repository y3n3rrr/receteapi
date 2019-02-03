using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EReceteAPI.Database.Entities
{
    public enum ReceteTuru
    {
        [Display(Name = "Belirtilmemiş")]
        Belirtilmemis = 0,

        [Display(Name = "Normal")]
        Normal = 1,

        [Display(Name = "Kırmızı")]
        Kirmizi = 2,

        [Display(Name = "Turuncu ")]
        Turuncu = 3,

        [Display(Name = "Mor ")]
        Mor = 4,

        [Display(Name = "Yeşil")]
        Yesil = 5
    }
}
