using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bai2.Models;

namespace Bai2.Models
{
    public class GiaiphuongtrinhB1
    {
        public double GiaiPTB1(double a, double b)
        {
            // ax+b=0
            double x;
            x = -b / a;
            return x;
        }
    }
}