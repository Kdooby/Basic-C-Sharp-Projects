using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Chain
{
    public class ChainConstructors
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChainConstructors(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("My ID is: {0} \nMy Name is: {1}", id, name);
            
        }
        
        public ChainConstructors(string name) : this(101, name)
        {
           
        }
        
    }
}
