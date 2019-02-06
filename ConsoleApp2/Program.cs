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
        }
        static void MethodA()
        {
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
            Console.ReadLine();
        }
       
    }
         
    
}
