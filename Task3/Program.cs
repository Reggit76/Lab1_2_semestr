using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class CollectionExtension
    {
        public static int Sum(this IEnumerable<int> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            var sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static double Sum(this IEnumerable<double> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            var sum = 0.0;
            foreach (var item in collection)
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
