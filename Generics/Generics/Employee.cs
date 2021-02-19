using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> // T representing the generic type parameter
    {
        public List<T> things { get; set; } // T representing the generic data type in the List, which matches the class parameter
    
        public void listOfThings()
        {
            foreach (T thing in things)
            {
                Console.WriteLine(String.Join("\n, ", thing)); // Prints everything in the list each separated by a new line
            }
            
        }
        
    }


}
