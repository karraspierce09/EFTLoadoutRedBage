using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GunModel
{
    public class GunDetail
    {
        [Display(Name = "Guns ID")]
        public int GunsId { get; set; }

        public string Title { get; set; }

        [Display(Name = "Gun")]
        public Gun Gun { get; set; }

        [Display(Name = "Lazers")]
        public Lazers Lazers { get; set; }

        [Display(Name = "Grips")]
        public Grips Grips { get; set; }

        [Display(Name = "Sights")]
        public Sights Sights { get; set; }

        [Display(Name = "Mag")]
        public Mag Mag { get; set; }

        [Display(Name ="Muzzle")]
        public Muzzle Muzzle { get; set; }
    }
}
