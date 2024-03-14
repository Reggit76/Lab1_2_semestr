using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class CollectionExtension
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            if (typeof(T) == typeof(int) && typeof(T) == typeof(double))
                throw new ArgumentException(nameof(T));

            dynamic sum = default(T);
            foreach (T item in collection)
            {
                sum += item;
            }
            return sum;
        }
    }

    public class Task3
    {
        public static void Run()
        {
            List<double> numbers = new List<double> { 0.5, 2, 3, 4, 5 };
            double sum = numbers.Sum();
            Console.WriteLine($"Сумма элементов коллекции: {sum}");
        }
    }
}
