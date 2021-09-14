using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    public class People
    {
        [Key]
        public string PeopleID { get; set; }
        [Required(ErrorMessage ="ID không được bỏ trống")]
        public string PeopleName { get; set; }
    }
}