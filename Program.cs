using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {   // Создайте метод int []  SubArray(int [] array, int index, int count). Метод возвращает часть полученного
        // в качестве аргумента массива, начиная с позиции указанной в аргументе index, размерностью, которая 
        // соответствует значению аргумента count. 
        // Если аргумент count содержит значение больше чем количество элементов, которые входят в выбираемую часть 
        // исходного массива (от указанного индекса index, до индекса последнего элемента), то  при формировании нового 
        // массива размерностью в count, заполните единицами те элементы, которые не были скопированы из исходного массива. 
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] partOfTheArray = new int[count];

            int g = 0;

            for (int i = index; i < partOfTheArray.Length + index; i++)
            {
                if (g < (count - index) && i < array.Length)
                {
                    partOfTheArray[g] = array[i];
                }
                else
                {
                    partOfTheArray[g] = 1;
                }
                g++;
            }

            return partOfTheArray;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the numbner of elements in the array: ");
            int[] arrayOfNum = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                Console.Write($"Enter {i} array element: ");
                arrayOfNum[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nArray element index: ");
            int index = Int32.Parse(Console.ReadLine());

            Console.Write("Array length: ");
            int count = Int32.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 5));

            arrayOfNum = SubArray(arrayOfNum, index, count);

            foreach (var i in arrayOfNum)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
