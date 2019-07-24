using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// help
// https://metanit.com/sharp/tutorial/3.38.php

namespace LesApp0
{
    /// <summary>
    /// клас для фабричного методу, який створює екземпляри типу T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()// where T : new()
        {
            return new T();
        }
    }
}
