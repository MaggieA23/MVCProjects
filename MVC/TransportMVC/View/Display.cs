using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMVC.View
{
    public class Display
    {
        public Display()
        {
            this.Kilometri = 0;
            this.TimeOfDay = null;
            this.Total = 0;
            this.GetValue();
        }

        public int Kilometri { get; set; }
        public string TimeOfDay { get; set; }
        public double Total { get; set; }
        public void GetValue()
        {
            this.Kilometri = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();
        }
        public void ShowResult()
        {
            Console.WriteLine(this.Total);
        }
    }
}
