using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRefrigerator
{
    class Refrigerator
    {
        
        private bool stateR;
        private bool stateF;
        private TemperatureRefrigerator temperatureR;
        private TemperatureFreezer temperatureF;
        public readonly string name;
        public Refrigerator(string Name)
        {
            name = Name;
            temperatureR = TemperatureRefrigerator.five;
            temperatureF = TemperatureFreezer.ten; 

        }
        public void OnRefrigerator()
        {
            stateR = true;
        }

        public void OffRefrigerator()
        {
            stateR = false;
        }
        public void OnFreezer()
        {
            stateF = true;
        }

        public void OffFreezer()
        {
            stateF = false;
        }

        public void IncTemperatureRefrigerator()
        {
            if ((int)temperatureR < 5)
            {
              temperatureR = ++temperatureR;  
            }
            else{}
            

        }
        public void DecTemperatureRefrigerator()
        {
            if ((int)temperatureR>1)
            {
               temperatureR = --temperatureR; 
            }
            

        }
        public void IncTemperatureFreezer()
        {
           
            if ((int)temperatureF > -15)
            {
                temperatureF = --temperatureF;
            }
        }
        public void DecTemperatureFreezer()
        {

            if ((int)temperatureF < -10)
            {
                temperatureF = ++temperatureF;
            }
        }
        public override string ToString()
        {
            string stateR;
            string stateF;
            if (this.stateR)
            {
                stateR = "On";
            }
            else
            {
                stateR = "Off";
            }
            if (this.stateF)
            {
                stateF = "On";
            }
            else
            {
                stateF = "Off";
            }
            int modeR = (int)temperatureR;
            int modeF = (int)temperatureF;



            return name + "." + "\t" + "     Состояние:" + "\t" + "  Температура:" + "\n" + "Холодильное отделение:" + "\t" + stateR + "\t" + "      "+modeR+"'C" + "\n" + "Морозильная камера:" + "\t" + stateF + "\t" +"    "+ modeF+"'C";
             
        }
    }
}
