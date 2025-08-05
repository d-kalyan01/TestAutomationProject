using OpenQA.Selenium.DevTools.V136.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    internal class Employee
    {
        // Add properties for id, name, and city
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Employee(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;

        }

        public class Implement
        {
            public static void Main(String[] args)
            {
                List<Employee> employees = new List<Employee>();
                
                    employees.Add(new Employee(10, "John", "Pune"));
                    employees.Add(new Employee(50, "Ram", "Mumbai"));
                    employees.Add(new Employee(80, "Ravi", "Mahad"));
                    employees.Add(new Employee(90, "Rajesh", "Pune"));


                var count = employees.Count(employees => employees.Name.StartsWith("R"));
                // In the above example lambda expression uses properties of List employees(list of objects) such as Name.startsWith
                Console.WriteLine("Number of Employees with id 10 is  " + count);


            }
        }
    }

}
