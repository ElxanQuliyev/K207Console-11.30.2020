using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K207Console
{
    static class Utilties
    {
        public static bool IsNumber(string text)
        {
            try
            {
                Convert.ToDecimal(text);
                return true;
            }
            catch (Exception)
            {

                Console.Clear();
                Console.WriteLine("Reqem daxil edin!");
                return false;

            }
        }
    }
}
