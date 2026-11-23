using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            //Вывести результирующий набор списков myCars и yourCars, содержащий все элементы с повторениями.
            var allCars = myCars.Concat(yourCars);
            foreach (string car in allCars)
                Console.WriteLine(car);
        }
    }
}
