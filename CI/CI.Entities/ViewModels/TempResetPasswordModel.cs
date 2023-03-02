using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CI.Entities.ViewModels
{
    public class TempResetPasswordModel
    {
        public string? Email { get; set; }

        public string? Token { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string?  NewPassword { get; set; }

        [Compare("NewPassword")]
        [NotMapped]
        public string? ConformPassword { get; set; }
    }
}
