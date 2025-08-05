using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPracticeYouTube.StepDefinitions
{
    internal class Vehicle:Car
    {
        public static void Main(string[] args)
        {
            Vehicle c1 = new Vehicle();
            Console.WriteLine(c1.CarName);
           // Console.WriteLine(c1.CarYear);
            Console.WriteLine(c1.CarPrice);
            Console.WriteLine(c1.CarColor);

            c1.publicMethodalMethod();
            //c1.privateMethod();
            c1.protectedMethod();
            c1.internalMethod();


        }
    }
}
