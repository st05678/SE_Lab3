using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    //Product содержит название продукта, количество упаковок на складе, описание.
    public class Product
    {
        public string Name { get; set; }      // название
        public int Number { get; set; } // кол-во упаковок
        public string Description { get; set; }    // описание
        public override string ToString()
        {
            return $"Продукт: {Name}, упаковок: {Number}, описание продукта: {Description}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создать список продуктов класса Product.
            //Выбрать из списка продукты с количеством упаковок меньше 10 единиц и вывести всю информацию о них.
            List<Product> products = new List<Product>
            {
                new Product {Name = "Молоко", Number = 25, Description = "1 л, 3.2%"},
                new Product {Name = "Хлеб", Number = 8,  Description = "Белый"},
                new Product {Name = "Сыр", Number = 3,  Description = "Мазерати, 200 г"},
                new Product {Name = "Яйца", Number = 40, Description = "С0, 10 шт."},
                new Product {Name = "Масло", Number = 23,  Description = "Сливочное, 82.5%"},
            };
            var lowProducts = from product in products
                              where product.Number < 10
                              select product;
            Console.WriteLine("Продукты с количеством упаковок меньше 10 единиц:");
            foreach (Product product in lowProducts)
                Console.WriteLine(product);
        }
    }
}
