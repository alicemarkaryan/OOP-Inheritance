using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone(500, "red", 2002);
            mobilePhone.Name();
            mobilePhone.MobileFunc(5552412);
            Iphone iphone = new Iphone(1500, "White", 2015, "Pro", "yesFingerPrint");
            Console.WriteLine(iphone.Price);
            iphone.Name();
            iphone.MobileFunc(5454);
            Iphone13 Ip13 = new Iphone13(1800, "Rose", 2021, "Yes", "FingerPrint", "faceId");
            Console.WriteLine(Ip13.Price);
            Console.WriteLine(Ip13.Color);
            Ip13.Color = "Pink";
            Console.WriteLine(Ip13.Color);
            Ip13.Name();
            Ip13.MobileFunc(124546);

        }
    }
}
