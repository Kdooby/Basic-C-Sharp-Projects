using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string example = "This is an example of a constant";
            Console.WriteLine(example);
            Console.ReadLine();

            string x = "This is an example of ";
            string y = "using the keyword \"var\". ";
            var z = x + y;
            Console.WriteLine(z);
            Console.ReadLine();


            var i = new ChainConstructors("Kevin");
            
            Console.ReadLine();


        }
    }
}
