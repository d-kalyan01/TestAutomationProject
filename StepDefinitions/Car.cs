using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace SeleniumPracticeYouTube.StepDefinitions
{
    public class Car : AbstractExamplecs
    {
        public string CarName = "Volvo";
        private int CarYear = 2023;
        protected int CarPrice = 50000;
        internal string CarColor = "Red";

        public void publicMethodalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }

        private void privateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        internal void internalMethod()
        {
            Console.WriteLine("This is another internal method.");
        }

         
     

public static void Main(string[] args)
        {
            Car a1 = new Car();
            Console.WriteLine(a1.CarName);
            Console.WriteLine(a1.CarYear);
            Console.WriteLine(a1.CarPrice);
            Console.WriteLine(a1.CarColor);

            List<Car> carList = new List<Car>();
            IList<Car> carIList = new List<Car>();
            carList.Take(1).ToList();
            Console.WriteLine("Car List Count: " + carList.Count);
            Console.WriteLine();

            HashSet<string> carSet = new HashSet<string>();
            carSet.Add("Toyota");
            carSet.Add("Honda");

               


            foreach (var car in carSet)
            {
                Console.WriteLine("Car Set Item: " + car);
            }

            try
            {
                int[] ints = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine("Array: " + ints[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException: " + e.Message);
            }

           
           




        }

        override public void display()
        {
            Console.WriteLine("Display method from abstract class.");
        }

        override public void show()
        {
            Console.WriteLine("Show method from abstract class.");
        }






    }
}
