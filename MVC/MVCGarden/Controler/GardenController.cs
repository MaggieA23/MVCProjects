using MVCGarden.Model;
using MVCGarden.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Controler
{
    public class GardenController
    {
        private Display displays;
        private Garden gardens;
        public GardenController()
        {
            displays = new Display();
            gardens = new Garden(displays.PriceVegetable,displays.PriceFruit,displays.KgVegetable,displays.KgFruit);
            displays.Total = gardens.CalculateSum();
            displays.ShowResult();
        }
    }
}
