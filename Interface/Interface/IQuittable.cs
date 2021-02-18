using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IQuittable // Interfaces always start with a capital "I".  Hence "I"Quittable
    {
        // Property 
        List<string> PersonQuit { get; set; }

        // Method
        void Quit();
        
    }
}
