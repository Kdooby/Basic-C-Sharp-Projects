using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Number cost = new Number();

            cost.Amount = 10.99m;
            Console.WriteLine("This item costs: " + cost.Amount);
            Console.ReadLine();
        
        }


        public struct Number
        {
            public decimal Amount { get; set; }

        }
    }
    
}
