using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simples_Inheritance_Example
{
    internal class Radio : EletricalDevice
    {
        //Child Class
        public Radio(bool isOn, string brand):base(isOn, brand)
        {

        }
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first!");
            }
        }
    }
}
