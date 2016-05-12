using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyRefrigerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Refrigerator myRef = new Refrigerator("Донбасс");
            string path = @"E:\программирование\works\MyRefrigerator\MyRefrigerator\bin\Debug\frig.dat";
            
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream("frig.dat", FileMode.Open))
                {
                     myRef = (Refrigerator)bf.Deserialize(fs);
                }
            }

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
                Console.WriteLine("s - Сохранить настройки");
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
                    case 's':
                        using (FileStream fs = new FileStream("frig.dat", FileMode.OpenOrCreate))
                        {
                            bf.Serialize(fs, myRef);
                        }
                        break;
                    
                    case '0':
                        
                        return;
                }
            }

            






        }
    }
}
/*Задание №1. Сериализация (Lec. 15)
В задании про эмулятор работы холодильника (Занятие №05. C#. Объектная модель, Задание №5. ООП)
добавьте следующий функционал: программа должна сохранять все введенные данные при выходе из 
программы посредством соответствующего пункта меню “Выход”. При запуске программа должна
проверять наличие файла с данными и загружать их автоматически, если существует файл, созданный в предыдущем сеансе работы.
Сохранение данных должно быть реализовано с использованием механизма сериализации.*/
