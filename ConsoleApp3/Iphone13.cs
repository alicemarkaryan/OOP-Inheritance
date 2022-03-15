using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Iphone13:Iphone
    {
        public string FaceId { get; set; }

        public Iphone13(decimal price, string color, int issueDate, string earPodsPro, string fingerPrint, string faceId) : 
            base( price, color, issueDate,  earPodsPro, fingerPrint)
        {
            this.FaceId = faceId;
        }


        public int MobileFunc(int numbers)
        {
            if (numbers != 5)
            {
                return numbers;
            }
            return 000; //help centre

        }

        public override void Name()
        {
            Console.WriteLine("Iphone13");
        }
    }
}
