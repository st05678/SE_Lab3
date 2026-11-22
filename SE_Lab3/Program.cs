using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //пр. 1
            /*int[] msv = { -1, 2, 3, -4 };
            var res = from n in msv
                      where n > 0
                      select n;
            foreach (int x in res)
                Console.WriteLine(x);*/
            //пр. 2 частотный анализ текста
            string s = "LINQ - это набор расширений для .NET, которые охватывают интегрированные в язык операции запроса, объединения и преобразования. Он расширяет синтакс языка C# для запросов и предоставляет библиотеки классов, позволяющие использовать преимущества этих возможностей.";

            var res = from n in s.ToLower().ToCharArray()
                      group n by n into g
                      let count = g.Count()
                      orderby count descending
                      select new { Letter = g.Key, Count = count };
            foreach (var item in res)
                Console.WriteLine(item);
        }
    }
}
