﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // для рандому
            Random rnd = new Random();

            // створюємо свою колекцію
            MyList<int> list = new MyList<int>();

            #region Створе даних для заповнення колекції масивами різної довжини
            // визначаємо скільки масивів необхідно використати
            // різних розмірів
            int numOfmasiv = rnd.Next(1, 10);
            
            // створюємо зубчастий масив щоб вручну все не писати (бо лінь :D )
            int[][] array = new int[numOfmasiv][];

            // тепер визначаємо яких розмірів вони мають бути
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[rnd.Next(1, 10)];
            }

            // заповнення зубчастого масиву даними
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(sbyte.MinValue, sbyte.MaxValue);
                }
            }

            // виводимо отримані дані
            Console.WriteLine("\n\tЗгенеровані дані зубчастого масиву:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            // передача даних цілими масивами в колекцію
            for (int i = 0; i < array.Length; i++)
            {
                list.AddRange(array[i]);
            }

            // виводимо список
            Console.WriteLine("\n\tТестування спроби виходу за діапазон:");
            list[-1] = 5;

            // вивід цілого списку
            Console.WriteLine("\n\tЕлементи поміщені в список:");
            Console.WriteLine("\n\t" + list.ToString());

            // Інформація про колекцію
            list.ShowInfo();

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
