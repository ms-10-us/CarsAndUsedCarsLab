using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    internal class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public List<Car> listOfCars = new List<Car>();

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }

        public Car (string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Make}\t" +
                $"{Model}\t" +
                $"{Year}\t" +
                $"{Price:c}\t";
        }

        public void ListCars()
        {
            for (int i = 0; i < listOfCars.Count; i++)
            {
                Console.WriteLine($"{i+1}. {listOfCars[i].ToString()}");
            }
        }

        public void Remove(int carIndex)
        {
            listOfCars.RemoveAt(carIndex - 1);
        }
    }
}
