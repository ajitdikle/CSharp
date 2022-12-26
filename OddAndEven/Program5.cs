using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment11
{
    public class Program5
    { //
        static void Main(String[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 21; i++) 
            {
                if (i%2 !=0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("The sum of all odd " + sum);
        }
    }

    
    }

