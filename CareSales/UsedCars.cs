using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSales
{  
    public class UsedCars : Cars
    {
        public UsedCars(double mileage)
        {
            Mileage = mileage;
        }
        public double Mileage { get; set; }
        public UsedCars(string make, string model, int year, decimal price, double mileage): base(make, model, year, price)
           
        {
            Mileage = mileage;
        }

     

        public override string ToString()
        {
            return base.ToString() + $" (USED) Mileage: {Mileage} miles";
        }
    }
}
