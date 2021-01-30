using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GunModel
{
    public class GunCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Title must contain at least one character.")]
        [MaxLength(300, ErrorMessage = "Title cannot contain more than 300 characters.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Gun")]
        public Gun Gun { get; set; }

        [Required]
        [Display(Name = "Mag")]
        public Mag Mag { get; set; }

        [Required]
        [Display(Name = "Grips")]
        public Grips Grips { get; set; }

        [Required]
        [Display(Name = "Sights")]
        public Sights Sights { get; set; }

        [Required]
        [Display(Name = "Muzzle")]
        public Muzzle Muzzle { get; set; }

        [Required]
        [Display(Name = "Lazers")]
        public Lazers Lazers { get; set; }

    }
}
