using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
            Console.ReadLine();
        }
        static void MethodA()
        {
            Console.WriteLine("i is {0} ", i);
            while (Peanut())
            {
                if(i>10)
                {
                    return;
                }
            }
        }
        static bool Peanut()
        {
            i++;
            return true;
            
        }
       
    }
         
    
}
