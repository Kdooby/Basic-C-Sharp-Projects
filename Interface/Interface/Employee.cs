using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            base.SayName();  
        }

        //Property
        public List<string> PersonQuit { get; set; }
        //Method
        public void Quit()
        {
            
            foreach (string quitter in PersonQuit) // for each person in the list of employees
            Console.WriteLine( "{0} says \"I Quit!\"", quitter); 
            
        }
        

    }
}
