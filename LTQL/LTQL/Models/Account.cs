using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LTQL.Models
{
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        

    }
}
//<roleManager defaultProvider = "usersRoleProvider" enabled = "true" >

// < providers >

// < clear />

// < add name = "usersRoleProvider" type = "LTQL.Models.UsersRoleProvider" />

//</ providers >

//</ roleManager >