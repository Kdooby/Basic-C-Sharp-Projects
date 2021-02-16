using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_2
{
    public class mathClass
    {
        public int same_method(int num)
        {
           int result = num + 25;
           return result;
        }

        public int same_method(decimal num)
        {
            int result = Convert.ToInt32(num);
            return result;
        }

        public int same_method(string num)
        {

            int result = Convert.ToInt32(num) * 5;
            return result;

        }
    }
}
