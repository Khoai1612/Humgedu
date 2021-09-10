using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV  { get; set; }
        public string TenSV  { get; set; }
        public string SDT { get; set; }
    }
}