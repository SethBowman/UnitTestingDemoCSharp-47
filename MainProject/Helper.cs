using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Helper
    {
        public int Add(int a, int b)
        {
            return a + b;           
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public string Greeting(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return "Hello!";
            }

            return $"Hello, {name}!";
        }
    }
}
