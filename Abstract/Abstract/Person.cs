using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        
        // Methods
        public virtual void SayName()
        {
            

        }
    }

    

}
