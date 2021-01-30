using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModel
{
    public class GunListView
    {
        [Display(Name = "Guns ID")]
        public int GunsId { get; set; }

        public string Title { get; set; }
    }
}
