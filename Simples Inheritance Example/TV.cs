using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simples_Inheritance_Example
{
    //Child Class
    internal class TV : EletricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first!");
            }
        }
    }
}
