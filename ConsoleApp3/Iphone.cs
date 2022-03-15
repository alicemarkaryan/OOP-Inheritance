using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Iphone:MobilePhone
    {
        public string EarPodsPro { get; set; }
        public string FingerPrint { get; set; }


        public Iphone(decimal price, string color, int issueDate,string earPodsPro, string fingerPrint) 
            :base(price,  color,  issueDate)
        {
            this.EarPodsPro=earPodsPro; this.FingerPrint = fingerPrint;
        }

         public int MobileFunc(int numbers)
        {
            if (numbers != 9)
            {
                return numbers;
            }
            return 555; //help centre

        }

        
        public override void Name()
        {
            Console.WriteLine("Iphone");
        }
    }
}
