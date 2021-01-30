using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Guns
    {
        [Key]
        public int GunsId { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public Gun Gun { get; set; }
        public Lazers Lazers { get; set; }

        public Sights Sights { get; set; }

        public Mag Mag { get; set; }
        public Grips Grips { get; set; }
        public Muzzle Muzzle { get; set; }



    }

    public enum Lazers
    {
        Fiction = 1,

        [Display(Name = "FlashLight")]
        FlashLight,

        [Display(Name = "BlueLazer")]
        BlueLazer,

        [Display(Name = "RedLazer")]
        RedLazer,

        [Display(Name = "GreenLazer")]
        GreenLazer,
    }

    public enum Sights
    {
        Fiction = 1,

        [Display(Name = "RedDot")]
        RedDot,

        [Display(Name = "Hollow")]
        Hollow,

        [Display(Name = "Holographic")]
        Holographic,

        [Display(Name = "RazorHollow")]
        RazorHollow,
    }
    public enum Mag
    {
        Fiction = 1,

        [Display(Name = "Magof30")]
        Magof30,

        [Display(Name = "Magof60")]
        Magof60,

        [Display(Name = "Magof100")]
        Magof100,

        [Display(Name = "Magof40")]
        Magof40,
    }
    public enum Grips
    {
        Fiction = 1,

        [Display(Name = "SideGrip")]
        SideGrip,

        [Display(Name = "ForwardGrip")]
        ForwardGrip,

        [Display(Name = "VerticalGrip")]
        VerticalGrip,

        [Display(Name = "MetalGrip")]
        MetalGrip,
    }
    public enum Muzzle
    {
        Fiction = 1,

        [Display(Name = "Lightweightsilencer")]
        Lightweightsilencer,
    }
    public enum Gun
    {
        Fiction = 1,

        [Display(Name = "M4")]
        M4,

        [Display(Name = "AK47")]
        AK47,

        [Display(Name = "AK74U")]
        AK74U,

        [Display(Name = "HK")]
        HK,
    }
}



