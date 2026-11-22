using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "Fallout 3", "Daxter 2", "System Shock 2", "Morrowind", "Pes 2013" };
            int[] B = { 2, -7, -10, 6, 7, 9, 3 };
            string[] C = { "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green", "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };

            //1)Написать запрос для нахождения элементов массива А, включающих цифры. 
            Console.WriteLine("Задание 1");
            var res1 = from n in A
                       where n.Any(char.IsDigit)
                       select (n);
            foreach (string i in res1)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Задание 2");

            //2)Написать запрос для нахождения отрицательных элементов массива В.
            var res2 = from n in B
                       where n < 0
                       select (n);
            foreach (int i in res2)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Задание 3");

            //3) Написать запрос для нахождения всех оттенков желтого цвета в массиве С. 
            var res3 = from n in C
                       where n.Contains("Yellow") || n.Contains("yellow")
                       select (n);
            foreach (string i in res3)
                Console.WriteLine(i);



        }
    }
}
