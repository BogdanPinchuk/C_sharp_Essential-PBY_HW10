using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створюємо словник ua-en
            var dictionary = new MyDictionary<string, string>();

            // щоб було простыше вызьмемо дані із умовно "вказаного" прикладу
            dictionary.Add("книжна", "book");
            dictionary.Add("ручка", "pen");
            dictionary.Add("сонце", "sun");
            dictionary.Add("яблуко", "apple");
            dictionary.Add("стіл", "table");

            // вивід інформації
            Console.WriteLine("\n\tСловник ua-en:\n");
            Console.Write(dictionary.ToString());

            // виводимо список
            Console.WriteLine("\n\tТестування спроби виходу за діапазон:");
            dictionary[-1] = "mouse";

            Console.WriteLine("\n\tТестування спроби найти елемент по ключу якого немає в списку:");
            dictionary["миша"] = "mouse";

            Console.WriteLine("\n\tТестування спроби найти елемент по ключу який є в списку: сонце");
            Console.WriteLine("\n\t" + dictionary["сонце"]);

            // Інформація про колекцію
            dictionary.ShowInfo();

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
