using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MobilePhone
    {
        public decimal Price { get;  }
        public string Color { get; set; }
        public int IssueDate { get; set; }


        public MobilePhone(decimal price, string color, int issueDate)
        {
            this.Price = SetPrice(price);    this.Color = color; this.IssueDate= issueDate; 
        }

        public decimal SetPrice(decimal price)
        {
            if(price > 1000)
            {
                return price;
            }
             return 0;
        }

        public int MobileFunc(int numbers)
        {
            if (numbers != 0)
            {
                return numbers;
            }
            return 1111; //help centre

        }

        public virtual void Name()
        {
            Console.WriteLine("MobilePhone");
        }


    }
}
