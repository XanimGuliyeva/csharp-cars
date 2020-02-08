using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Car masin1 = new Car("Lexus","A10");
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top to");
                Console.WriteLine("3.TLocal km");
                Console.WriteLine("4.Global km");
                Console.WriteLine("5.Exit");
                Console.WriteLine(">>>>>>>>>>>>>> ");
                userInput = Console.ReadLine();
                if (CheckInput(userInput))
                {
                    switch (userInput) {
                        case "1":
                            masin1.Go();
                            break;
                        case "2":
                            Console.WriteLine("Masina benzin vuruldu");
                            break;
                        case "3":
                            Console.WriteLine("Local km bu qederdir");
                            break;
                        case "4":
                            Console.WriteLine("Qlobal km bu qederdir");
                            break;
                        default:
                            Console.WriteLine("Zehmet olmazsa yuxaridakilardan birini yazin");
                            break;
                    }
                }
                else {
                    Console.WriteLine("Yuxaridaki reqemleri daxil edin");
                        }
            } while (userInput != "5");
            
        }




        static bool CheckInput(string input) {
            try
            {
                int userInput = Convert.ToInt32(input);
                    return true;
            }
            catch 
            {

               return false;
            }
        }
    }




    class Car {
        public string Model;
        public string Marka;
        private int FullEff;
        private int CurrentEff;
        private int MaxFuel;
        int neededkm = 0;
        public Car(string marka, string model,int fulleff=12,int currentEff=30,int maxFuel=60)
        {
            Marka = marka;
            Model = model;
            FullEff = fulleff;
            CurrentEff = currentEff;
            MaxFuel = maxFuel;

    }

        public void Go()
        {
            int neededkm = 0;
            while (neededkm == 0)
            {
                Console.WriteLine("Nece kilometr getmek isteyirsiniz");
                string input = Console.ReadLine();
                if (CheckInput(input))
                {
                    neededkm = Convert.ToInt32(input);
                    if (MaxFuel <= neededkm / 100 * FullEff)
                    {
                        Console.WriteLine("Sizin kifayet qeder benzininin yoxdur.Benzin daxil edin");
                    }
                    else
                    {
                        CurrentEff -= CurrentEff - (neededkm / 100 * FullEff);
                        Console.WriteLine("Siz {0} getseniz {1} litr istifade edeceksen",neededkm,CurrentEff);

                    }

                }

                else
                {
                    Console.WriteLine("Musbet reqem daxil edin");
                }

            }
        }
        static bool CheckInput(string input)
        {
            try
            {
                int neededKM = (int)Convert.ToUInt32(input);
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
    
}
