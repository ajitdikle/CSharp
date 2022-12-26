using Math.VolumeFormula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssign
{
    public class VolumeValue
    {
        static void Main(string[] args)
        {

            double result = Volume.VolumnOfSphere(10.2);
            Console.WriteLine(result);

            double result1 = Volume.VolumnOfCone(11.2, 12.6);
            Console.WriteLine(result1);

            double result2 = Volume.VolumnOfCuboid(2.3, 3.3, 55.4);
            Console.WriteLine(result2);
        }
    }
}

