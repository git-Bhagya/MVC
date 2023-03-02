﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Entities.ViewModels
{
    public class ForgotViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
