using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    
    public class MultiCastDelegate
    {
        delegate void DelOp(int a, int b);
        public static void ImplementDelegate()
        {
            //Delegate instantiation
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(1, 2);
            obj(8, 3);

            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add( int a, int b)
            {
                Console.WriteLine(" Addition={0}", a + b);

            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple={0}", a * b);

            }
        }

     }
}
