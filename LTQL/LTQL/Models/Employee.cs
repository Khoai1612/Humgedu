using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Models
{
    public class Employee : People
    {
        [AllowHtml]
        public string Company { get; set; }
        public string Address { get; set; }
    }
}