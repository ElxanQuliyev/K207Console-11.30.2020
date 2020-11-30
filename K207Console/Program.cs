using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace K207Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Bmw","M5",50,80,14);

            
            string userInput;
            do
            {

                Console.OutputEncoding = Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*****__Az Petrol__*****");
                Console.WriteLine("1.GO");
                Console.WriteLine("2.Topup");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                Console.Write(">>>>>>>>");
                userInput = Console.ReadLine();
                if (Utilties.IsNumber(userInput))
                {
                    int userInt = Convert.ToInt32(userInput);
                    switch (userInt)
                    {
                        case 1:
                            car1.Go();
                            break;
                        case 2:
                            car1.TopUp();
                            break;
                        case 3:
                            car1.Stop();
                            break;
                        case 4:
                            Console.WriteLine("Yaxşı yol");
                            break;
                        default:
                            Console.WriteLine("Yalnız yuxarıdakı sıyahıdan rəqəm seçin!");
                            break;
                    }
                }
            } while (userInput!="4");
       
        }
    }
}
