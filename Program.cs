using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        public class MethodOverloading
        {

            public void Arguments()
            {
                Console.WriteLine("No Arguments");
            }

            public void Arguments(int number)
            {
                Console.WriteLine("Integer Arguments");
            }
            public void Arguments(string name)
            {
                Console.WriteLine("String Arguments");
            }
            public void Arguments(double number)
            {
                Console.WriteLine("Double Arguments");
            }

            //public void Arguments(int number1, float number2)
            //{
            //    Console.WriteLine("int-float arguments");
            //}

            //public void Arguments(float number1, int number2)
            //{
            //    Console.WriteLine("float-int arguments");
            //}

        }


        static void Main(string[] args)
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.Arguments();
            methodOverloading.Arguments(10);
            methodOverloading.Arguments("Subhashish");
            methodOverloading.Arguments(10.5);
            methodOverloading.Arguments('A');

            //methodOverloading.Arguments(10, 10); //ambiguity
            //methodOverloading.Arguments(10f, 10f);
            


            //Type Cast and Conversion Or Promotion
            // char --> int --> long --> float --> double


        }
    }
}
