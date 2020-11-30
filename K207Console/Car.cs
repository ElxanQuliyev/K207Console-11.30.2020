using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K207Console
{
    class Car
    {
        public string Marka;
        public string Model;
        public decimal CurrentFuel;
        public decimal MaxFuel;
        public decimal FullEffect;
        private decimal GlobalKM;
        public Car(string marka,string model,int CurrentFuel,int MaxFuel,int FullEffect)
        {
            Marka = marka;
            Model = model;
            this.CurrentFuel = CurrentFuel;
            this.MaxFuel = MaxFuel;
            this.FullEffect = FullEffect;
        }

        public void Go()
        {
            Console.Write("Nece km yol gedeceksiz?:");
            string neededKM = Console.ReadLine();
            if (Utilties.IsNumber(neededKM))
            {
                decimal needKMInt = Convert.ToDecimal(neededKM);
                if (CurrentFuel >= needKMInt * FullEffect / 100)
                {
                    CurrentFuel -= needKMInt * FullEffect / 100;
                    Console.WriteLine($"Siz {needKMInt} km yol qət etdiniz.Hal-hazırda {CurrentFuel} l benzin qaldı.");
                    GlobalKM += needKMInt;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Benzin kifayət qədər deyil. Benzin doldurun!\n");
                }
            }         
        }

        public void TopUp()
        {
            Console.Write("Neçə litr benzin yükləmək istəyirsiniz?:");
            string neededFuel = Console.ReadLine();
            if (Utilties.IsNumber(neededFuel))
            {
                decimal fuelDec = Convert.ToDecimal(neededFuel);
                if (MaxFuel >= fuelDec+CurrentFuel)
                {
                    CurrentFuel += fuelDec;
                    Console.WriteLine($"{fuelDec}l benzin dolduruldu");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Maximum benzin tutumunu aşdınız!\n");
                }
            }
        }
        public void Stop()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Siz indiyə qədər {GlobalKM} km yol qət etimisiniz. Maşında {CurrentFuel}l benzin var.\n") ;
        }
    }


}
