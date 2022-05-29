using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayiString = "12,34";
            double sayiDouble;


            //double convertTest = Convert.ToDouble(sayiString.Replace("," , "."), CultureInfo.InvariantCulture);
            //Console.WriteLine(convertTest.ToString(new CultureInfo("tr")));

            bool donusebiliyorMu = double.TryParse(sayiString.Replace("," , ".") , NumberStyles.Any , CultureInfo.InvariantCulture, out sayiDouble);
            if(donusebiliyorMu)
                Console.WriteLine(sayiDouble);


            string[] sayilar = new string[ 12 ] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" ,"," ,"." };

            bool sayiMi = false;
            foreach (char sayiChar in sayiString)
            {
                sayiMi = false;
                foreach (string sayi in sayilar)
                {
                    if (sayiChar.ToString() == sayi)
                    {
                        sayiMi = true;
                        break;
                    }
                }
                //sayiMi = sayilar.Contains(sayiChar.ToString());
                //if (!sayiMi)
                //{
                //    break;
                //}
            }
            if (sayiMi)
                Console.WriteLine(sayiString);
            else
                Console.WriteLine("Sayı değil");
            Console.ReadLine();
        }
    }
}
