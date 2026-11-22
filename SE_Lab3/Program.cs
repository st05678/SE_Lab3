using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Lab3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
    }
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


            //пр. 2 (частотный анализ текста)
            /*string s = "LINQ - это набор расширений для .NET, которые охватывают интегрированные в язык операции запроса, объединения и преобразования. Он расширяет синтакс языка C# для запросов и предоставляет библиотеки классов, позволяющие использовать преимущества этих возможностей.";

            var res = from n in s.ToLower().ToCharArray()
                      group n by n into g
                      let count = g.Count()
                      orderby count descending
                      select new { Letter = g.Key, Count = count };
            foreach (var item in res)
                Console.WriteLine(item);*/

            List<Student> list = new List<Student>();
            list.Add(new Student { FirstName = "Светлана", LastName = "Омельченко", Scores = new int[] { 98, 92, 81, 60 } });
            list.Add(new Student
            {
                FirstName = "Карл",
                LastName = "Одолин",
                Scores = new int[] { 75, 84, 91, 39 }
            });
            list.Add(new Student
            {
                FirstName = "Сергей",
                LastName = "Мортинский",
                Scores = new int[] { 88, 94, 65, 91 }
            });
            list.Add(new Student
            {
                FirstName = "Ольга",
                LastName = "Иванова",
                Scores = new int[] { 97, 89, 85, 82 }
            });

            var query = from Student student in list
                        where student.Scores[0] > 95
                        select student;

            foreach (Student s in query)
                Console.WriteLine(s.LastName + ": " + s.Scores[0]);

            // Оставить консольное окно открытым в режиме отладки
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
