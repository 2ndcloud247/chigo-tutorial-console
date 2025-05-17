using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persone
    {
       
            public string Name;
            public int Age;

            public void SayHello()
            {
                Console.WriteLine("Hi, I'm " + Name + "I am, " + Age);
            }
        
    }
}
