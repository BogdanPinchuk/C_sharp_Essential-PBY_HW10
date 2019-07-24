using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення екземплярів різних типів по слабкій ссилці
            Console.WriteLine("\n\tCтворення екземплярів різних типів:");

            Console.WriteLine("\nСтворено екземпляр типу:");
            Console.WriteLine(MyClass<int>.FactoryMethod().GetType());

            Console.WriteLine("\nСтворено екземпляр типу:");
            Console.WriteLine(MyClass<bool>.FactoryMethod().GetType());

            Console.WriteLine("\nСтворено екземпляр типу:");
            Console.WriteLine(MyClass<char>.FactoryMethod().GetType());

            Console.WriteLine("\nСтворено екземпляр типу:");
            Console.WriteLine(MyClass<DateTime>.FactoryMethod().GetType());

            Console.WriteLine("\nСтворено екземпляр типу:");
            Console.WriteLine(MyClass<object>.FactoryMethod().GetType());

            //delay
            Console.ReadKey(true);
        }
    }
}
