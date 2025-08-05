using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorialsProject.Utilities
{
    internal class ReadAppSettings
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName)
    .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true)
    .Build();



            string browser = configuration["AppSettings:browser"];

            string environment = configuration["AppSettings:environment"];

            string testsiteurl = configuration["AppSettings:testsiteurl"];


            Console.WriteLine("Browser:"+ browser);

        }

    }
}
