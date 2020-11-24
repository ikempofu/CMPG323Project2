using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DimensionDataCollab.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        public string password { get; set; }

        [Display(Name ="Comfirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        [Compare("password", ErrorMessage ="Passwords do not match")]
        public string comfirm_password { get; set; }
    }
}