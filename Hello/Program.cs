using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        /*enum gradus : int
        {
            min=0,
            krit=72,
            max=100,
        }*/
        static void Main(string[] args)
        {
            /*1
             Console.WriteLine("Hello!");
            
            int i = 10;
            Console.WriteLine(i);
            int i = 100;
            Console.WriteLine(i); 
            //Не запускается, нужно один раз проинициализировать

            */

            /*2
            const int k  = 10;
            Console.WriteLine(k);
            // При изменении объявлении не инициализированной константы компилятор выдает ошибку.
            */

            /*3
            Console.WriteLine("Минимальная температура= " +(int) gradus.min);
            Console.WriteLine("Критическая температура= " + (int)gradus.krit);
            Console.WriteLine("Максимальная температура= " + (int)gradus.max);
            */

            Console.Write("a=" );
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=" );
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=" );        
            int c = int.Parse(Console.ReadLine());
                        

            Console.WriteLine("1)" + "{0} + {1} = {2}", a, b, a+b);
            Console.WriteLine("2)" + "{0} + {1} + {2} = {2} + {1}+ {0}", a,b,c);
            Console.WriteLine("3)" + "{0} + {1} + {2} = {3}", a, b, c, a + b + c);

            Console.Write("a=" );
            float d = float.Parse(Console.ReadLine());
            Console.Write("b=" );
            float e = float.Parse(Console.ReadLine());
            Console.Write("c=" );          
            float f = float.Parse(Console.ReadLine());
            

            Console.WriteLine("4)" + "{0} * {1} = {2}", d, e, d * e);
            Console.WriteLine("5)" + "{0:.###} / {1:.###} = {2:.###}", d, e, d / e);
            Console.WriteLine("2)" + "({0:.##} + {1:.##}) + {2:.##} = {0:.##} + ({1:.##} + {2:.##})", d, e, f);

        }
    }
}
