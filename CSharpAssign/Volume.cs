using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.VolumeFormula
{
     public class Volume
    {
        public static double VolumnOfSphere(double radius)
        {
            double ans = 4 * 3.14 * radius * radius * radius / 3;
            return ans;
        }
        public static double VolumnOfCone(double radius, double height)
        {
            double ans = 3.14 * radius * radius * height / 3;
            return ans;
        }
        public static double VolumnOfCuboid(double length, double width, double height)
        {
            double ans = length * width * height;
            return ans;
        }
    }
}
