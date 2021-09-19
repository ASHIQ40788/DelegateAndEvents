using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //Delegate Definition or Declaration
    public delegate int operation(int a, int b);
    class Program
    {
        //Method that is passes as an Argument
        //It has same signature as Delagetes
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Delegates");

            //Delegate instantiation 
            operation obj = new operation(Addition);

            //output of SingleDelegate
            Console.WriteLine("Addition is={0}", obj(23, 27));
            Console.WriteLine();

            //MultiCastDelegate
            MultiCastDelegate.ImplementDelegate();
            Console.Read();

        }
        
    }
}
