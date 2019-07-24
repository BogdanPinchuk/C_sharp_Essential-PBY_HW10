using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Клас для методів розширення
    /// </summary>
    static class Extention
    {
        /// <summary>
        /// Метод розшинення
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="list">Колекція</param>
        /// <returns></returns>
        public static T[] GetArray<T>(this MyList<T> list)
        {
            // можна вернути лише наявні елементи а не весь масив
            T[] array = new T[list.Count];

            // копіюємо значення
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }

            // повертаємо масив
            return array;
        }
    }

}
