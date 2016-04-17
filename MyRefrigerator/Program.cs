using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRefrigerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Refrigerator myRef = new Refrigerator("Донбасс");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(myRef.ToString() + "\n");
                Console.WriteLine("Нажмите клавишу для выполнения действия:");
                Console.WriteLine("1 - Включить холодильную камеру.");
                Console.WriteLine("2 - Выключить холодильную камеру.");
                Console.WriteLine("3 - Включить морозильную камеру.");
                Console.WriteLine("4 - Выключить морозильную камеру.");
                Console.WriteLine("5 - Холодильное отделение - повышение температуры.");
                Console.WriteLine("6 - Холодильное отделение - понижение температуры.");
                Console.WriteLine("7 - Морозильное отделение - повышение температуры.");
                Console.WriteLine("8 - Морозильное отделение - понижение температуры.");
                Console.WriteLine("0 - Выйти");

                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        myRef.OnRefrigerator();
                        break;
                    case '2':
                        myRef.OffRefrigerator();
                        break;
                    case '3':
                        myRef.OnFreezer();
                        break;
                    case '4':
                        myRef.OffFreezer();
                        break;
                    case '5':
                        myRef.IncTemperatureRefrigerator();
                        break;
                    case '6':
                        myRef.DecTemperatureRefrigerator();
                        break;
                    case '7':
                        myRef.DecTemperatureFreezer();
                        break;
                    case '8':
                        myRef.IncTemperatureFreezer();
                        break;
                    
                    case '0':
                        return;
                }
            }

            






        }
    }
}
