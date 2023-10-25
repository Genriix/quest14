using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest14._2
{
    class Program
    {
        static void Calculate(int n)
        { 
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++) 
            { 
                array[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            int max = array[0];
            int min = array[0];
            int sum = 0;
            double average;
            Console.Write("Нечетные значения массива: ");
            foreach (int num in array)
            {
                if (num > max) { max = num; }
                if (num < min) { min = num; }
                sum += num;
                if (num % 2 != 0) { Console.Write(num + " "); }
            }
            average = (double)sum / n;
            Console.WriteLine($"\n" +
                $"Наибольшее значение массива: {max}\n" +
                $"Наименьшее значение массива: {min}\n" +
                $"Общая сумма элементов массива: {sum}\n" +
                $"Среднее арифметическое всех элементов массива: {average}\n" +
                $"\n" +
                $"Для выхода введите q, для продолжения нажмите enter\n");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main()
        {
            string s = "";
            while (s != "q") 
            {
                Console.WriteLine("" +
                    "Для выхода введите q\n" +
                    "Введите размерность массива:");
                s = Console.ReadLine();
                try 
                {
                    Calculate(int.Parse(s)); // Метод выполнения задания
                } 
                catch 
                {
                    Console.WriteLine("" +
                        "\nОшибка ввода\n" +
                        "Введите числовые значения!!!\n");
                }
            }
        }
    }
}
