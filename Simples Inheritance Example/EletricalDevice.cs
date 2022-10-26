using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simples_Inheritance_Example
{
    //Parent - Base
    internal class EletricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public EletricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the TV
        public void SwitchOff()
        {
            IsOn = false;
        }
        public void Listen()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first!");
            }
        }
    }
    }
