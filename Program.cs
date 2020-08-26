using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaofractangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, weigth, area;
            Console.WriteLine("Enter the Value of Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the weigth: ");
            weigth = Convert.ToDouble(Console.ReadLine());
            area = length * weigth;
            Console.WriteLine("The area of the rantangle is  " + area);
        }
    }
}
