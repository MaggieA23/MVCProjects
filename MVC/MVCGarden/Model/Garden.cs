using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Model
{
    public class Garden
    {
        public Garden(decimal priceVegetable, decimal priceFruit, int kgVegetable, int kgFruit)
        {
            this.PriceVegetable = priceVegetable;
            this.PriceFruit = priceFruit;
            this.KgVegetable = kgVegetable;
            this.KgFruit = kgFruit;
        }

        public decimal PriceVegetable { get; set; }
        public decimal PriceFruit { get; set; }
        public int KgVegetable { get; set; }
        public int KgFruit { get; set; }
        public decimal CalculateSum()
        {
            return  (this.KgFruit * this.PriceFruit + this.KgVegetable * this.PriceVegetable)/1.94m ;
        }
    }
}
