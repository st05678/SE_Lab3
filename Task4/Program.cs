using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //Создать список автомобилей класса Car. Выбрать из списка автомобили белого цвета и вывести всю информацию о них.
    public class Car
    {
        public double MaxSpeed {get; set;}   // максимальная скорость, км/ч
        public string Color {get; set;}      // цвет
        public string Manufacturer {get; set;} // производитель
        public int Passengers {get; set;}    // число пассажиров
        public override string ToString()
        {
            return $"Автомобиль: {Manufacturer}, цвет: {Color}, макс. скорость: {MaxSpeed} км/ч, пассажиров: {Passengers}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
                {
                    new Car { MaxSpeed = 220, Color = "Белый",  Manufacturer = "Toyota",   Passengers = 5 },
                    new Car { MaxSpeed = 180, Color = "Красный", Manufacturer = "Lada",    Passengers = 4 },
                    new Car { MaxSpeed = 250, Color = "Белый",  Manufacturer = "BMW",      Passengers = 5 },
                    new Car { MaxSpeed = 160, Color = "Синий",  Manufacturer = "Renault",  Passengers = 7 },
                    new Car { MaxSpeed = 200, Color = "Белый",  Manufacturer = "Kia",      Passengers = 4 },
                };
            //только белые автомобили
            var whiteCars = from car in cars
                            where car.Color == "Белый"
                            select car;

            Console.WriteLine("Автомобили белого цвета:");
            foreach (Car car in whiteCars)
                Console.WriteLine(car);
        }
    }
}
