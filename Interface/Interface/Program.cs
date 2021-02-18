using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.SayName();

            IQuittable quit = new Employee();  // Polymorphism.  
            quit.PersonQuit = new List<string>() { "Kevin" };  // Creates new PersonQuit list and gives it a name
            quit.Quit(); // calls Quit()
            Console.ReadLine();
        }
    }
}
