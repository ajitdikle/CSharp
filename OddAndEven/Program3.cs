using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment11
{
    public class Program3
    {
        static void Main3(string[] args)
        { 
            int sum = 0;
            int i = 0;
            for (i = 0; i <= 50; i++)
            {
                if (i% 2== 0)
                {
                    sum=sum+i;
                }
          
            }
            Console.WriteLine(sum);
            if (sum % 2==0)
            {
                Console.WriteLine("It is even no" + sum);
            }
            else
            {
                Console.WriteLine("It is odd no" + sum);
            }
        }

    }
}
