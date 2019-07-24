using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "...аналогично экземпляру класса Dictionary (Урок 6 пример 5)..."
// це взагалі не те, посилання дано не взагалі щось "ліве"
// а щось схоже на словних знаходиться:
// базовий рівень, урок 5, 2 тема індексатори, 5 приклад

namespace LesApp2
{
    /// <summary>
    /// Мій словник
    /// </summary>
    class MyDictionary<TKey, TValue>
    {
        /// <summary>
        /// Ключі
        /// </summary>
        private TKey[] keys;
        /// <summary>
        /// Значення
        /// </summary>
        private TValue[] values;
        /// <summary>
        /// Кількість елемнтів в словнику
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Ємність словника
        /// </summary>
        public int Capacity { get { return keys.Length; } }

        /// <summary>
        /// Конструктор
        /// </summary>
        public MyDictionary()
        {
            // 4 - стандартне значення за замовчуванням
            keys = new TKey[4];
            values = new TValue[4];
            // установка початкового значення елементів
            Count = 0;
        }

        /// <summary>
        /// індексатор доступу по номеру елемента
        /// </summary>
        /// <param name="index">індекс</param>
        /// <returns></returns>
        public TValue this[int index]
        {
            get
            {
                if (0 <= index && index < Count)
                {
                    return values[index];
                }
                else
                {
                    Error("Спроба виходу за межі колекції/масиву.");
                    return default;
                }
            }
            set
            {
                if (0 <= index && index < Count)
                {
                    values[index] = value;
                }
                else
                {
                    Error("Спроба виходу за межі колекції/масиву.");
                }
            }
        }

        /// <summary>
        /// Індексатор доступу до ключу
        /// </summary>
        /// <param name="index">індекс</param>
        /// <returns></returns>
        public TValue this[TKey index]
        {
            get
            {
                // шукаємо елемент
                for (int i = 0; i < Count; i++)
                {
                    if (index.Equals(keys[i]))
                    {
                        return values[i];
                    }
                }

                // якщо нічого не знайдено
                Error("Вказаний ключ відсутній.");
                return default;
            }
            set
            {
                // шукаємо елемент
                for (int i = 0; i < Count; i++)
                {
                    if (index.Equals(keys[i]))
                    {
                        values[i] = value;
                    }
                }

                // якщо нічого не знайдено
                Error("Вказаний ключ відсутній.");
            }
        }

        /// <summary>
        /// Помилка, вихыд за межі масиву
        /// </summary>
        private void Error(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t" + s);
            Console.ResetColor();
        }

        /// <summary>
        /// Зміна розміру масиву
        /// </summary>
        /// <param name="newSize">новий розмір масиву</param>
        private void Resize(int newSize)
        {
            // тимчасові масиви
            TKey[] tempKey = new TKey[newSize];
            TValue[] tempValue = new TValue[newSize];

            // копіювання даних
            for (int i = 0; i < Count; i++)
            {
                tempKey[i] = keys[i];
                tempValue[i] = values[i];
            }

            // зміна ссилок
            keys = tempKey;
            values = tempValue;
        }

        /// <summary>
        /// Додавання масиву значень
        /// </summary>
        /// <param name="mas">масив значень</param>
        public void Add(TKey key, TValue value)
        {
            // перевырка чи всі елемнти помістяться в наявний масив
            if (Count == Capacity)
            {
                Resize(Capacity * 2);
            }

            // Занесення даних
            keys[Count] = key;
            values[Count++] = value;
        }

        /// <summary>
        /// Виведення результату словника
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // для зцеплення рядків
            var s = new StringBuilder();
            // внесення даних з колекції/списку
            for (int i = 0; i < Count; i++)
            {
                s.Append("\t" + keys[i].ToString() + " - " 
                    + values[i].ToString() + "\n");
            }

            return s.ToString();
        }

        /// <summary>
        /// Виведення інформації про колекцію
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"\n\tКількість елемнтів в колекції: {Count}");
            Console.WriteLine($"\tЄмність колекції: {Capacity}");
            Console.WriteLine($"\tТип даних ключа: {typeof(TKey).Name}");
            Console.WriteLine($"\tТип даних значення: {typeof(TValue).Name}");
        }
    }
}
