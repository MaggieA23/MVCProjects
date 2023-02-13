using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
   public  class Display
    {
        public Display()
        {
            this.PriceVegetable = 0;
           this.PriceFruit = 0;
            this.KgVegetable = 0;
            this.KgFruit = 0;
            this.GetValue();
        }

        public decimal PriceVegetable { get; set; }
        public decimal PriceFruit { get; set; }
        public int KgVegetable { get; set; }
        public int KgFruit { get; set; }
        public decimal Total { get; set; }
        public void GetValue()
        {
            this.PriceVegetable = decimal.Parse(Console.ReadLine());
            this.PriceFruit = decimal.Parse(Console.ReadLine());
            this.KgVegetable = int.Parse(Console.ReadLine());
            this.KgFruit= int.Parse(Console.ReadLine());
        }
        public void ShowResult()
        {
            Console.WriteLine(this.Total);
        }
    }
}
