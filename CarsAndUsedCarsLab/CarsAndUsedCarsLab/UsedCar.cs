using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{Make}\t" +
                $"{Model}\t" +
                $"{Year}\t" +
                $"{Price:c}\t" +
                $"{Mileage}\t";
        }
    }
}
