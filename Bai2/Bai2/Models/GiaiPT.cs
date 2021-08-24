using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class GiaiPT
    {
        public double GiaiPhuongTrinhBacNhat(double a,double b)
        {
            // ax+b=0
            double x;
            x = -b / a;
            return x;
        }
    }
}