using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMVC.Model
{
   public  class Transport
    {
        public Transport(int kilometri, string timeOfDay)
        {
            this.Kilometri = kilometri;
            this.TimeOfDay = timeOfDay;
        }

        public int Kilometri { get; set; }
        public string TimeOfDay { get; set; }

        public double CalculatePrice()
        {
            double price = 0;
            if (Kilometri >= 100)
            {
                price = this.Kilometri * 0.06;
            }
            else if (Kilometri >= 20)
            {
                price = this.Kilometri * 0.09;
            }
            else
            {
                if (TimeOfDay.ToLower() == "day")
                {
                    price = 0.70 + this.Kilometri * 0.79;
                }
                else if (TimeOfDay.ToLower() == "night")
                {
                    price = 0.70 + this.Kilometri * 0.90;
                }
            }
            return price;
        }   
    }
}
