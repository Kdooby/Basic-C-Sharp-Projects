using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> Employees = new List<Employees>()  // Main list of employees
            {
                new Employees() { FirstName = "Joe", LastName ="Montana", ID = 4},
                new Employees() { FirstName = "Makenna", LastName ="Meyer", ID = 8},
                new Employees() { FirstName = "Nick", LastName ="Lonien", ID = 10},
                new Employees() { FirstName = "Bob", LastName ="Cat", ID = 3},
                new Employees() { FirstName = "Bear", LastName ="Dog", ID = 12},
                new Employees() { FirstName = "Kyle", LastName ="McCarthy", ID = 22},
                new Employees() { FirstName = "Hilary", LastName ="Grummen", ID = 19},
                new Employees() { FirstName = "Joe", LastName ="Rogan", ID = 29},
                new Employees() { FirstName = "Tessa", LastName ="Utigard", ID = 14},
                new Employees() { FirstName = "Jeremy", LastName ="Keeley", ID = 32},


            };

            List<Employees> JoeList1 = new List<Employees>();  

            foreach (Employees name in Employees)
            {
                if (name.FirstName == "Joe")
                {
                    JoeList1.Add(name); // Add employee to new list 
                    Console.WriteLine("{0} {1} is on this list.", name.FirstName, name.LastName);

                }

            }
            Console.ReadLine();


            // LAMBDA EXPRESSION
            List<Employees> JoeList2 = new List<Employees>();
            JoeList2 = Employees.Where(x => x.FirstName == "Joe").ToList(); // Using Lambda, Add employee to new list 
            foreach (Employees name in JoeList2)
            {
                Console.WriteLine("{0} {1} is on this list also.", name.FirstName, name.LastName);
                
            }
            Console.ReadLine();


            // LAMBDA EXPRESS + 5
            List<Employees> JoeList3 = new List<Employees>();
            JoeList3 = Employees.Where(x => (x.ID > 5)).ToList(); //Using Lambda, if employees ID is greater than 5, add to new list
            Console.WriteLine("These employees have an ID number greater than 5: ");

            foreach (Employees name in JoeList3)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.ID);
            }
            Console.ReadLine();
            
            







        }
    }
}
