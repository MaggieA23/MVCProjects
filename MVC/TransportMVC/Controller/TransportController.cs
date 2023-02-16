using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMVC.Model;
using TransportMVC.View;

namespace TransportMVC.Controller
{
    public class TransportController
    {
        private Display displays;
        private Transport transport;
        public TransportController()
        {
           Display displays = new Display();
            Transport transport = new Transport(displays.Kilometri, displays.TimeOfDay);
            displays.Total = transport.CalculatePrice();
            displays.ShowResult();
        }
    }
}
