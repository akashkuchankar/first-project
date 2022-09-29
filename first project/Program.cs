using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2022;
            string month = "Sept";
            float percentage = 89.65F;
            double a = 89.65;
            // by using + sign
            Console.WriteLine("current year is "+year+"current month is "+ month);
            // placeholder
            Console.WriteLine("current year is {0} & current month is {1}",year,month);
            // interpolation
            Console.WriteLine($"current year is {year} & current month is {month}");
            Console.WriteLine(year);
            Console.WriteLine(month);

           

        }
    }
}
