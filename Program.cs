using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 6
Дана целочисленная прямоугольная матрица. Определить:
1.количество столбцов, содержащих хотя бы один нулевой элемент;
2.номер строки, в которой находится самая длинная серия одинаковых элементов. */

namespace _4_1_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 8, 0, 6, 6, 0 },
                { 7, 7, 7, 7, 7 },
                { 8, 8, 4, 5, 5 },
                { 12, 0, 3, -4, 5 },
            };

            // Количество столбцов, содержащих хотя бы один нулевой элемент;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool flag = false;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)                    
                        flag = true;                    
                }
                if (flag)
                    count++;
            }
            Console.WriteLine($"count = {count}");

            // Подсчет количества одинаковых элементов.
            List<int> amounts = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int amount = 1;                
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                    {
                        amount++;
                    }
                }
                amounts.Add(amount);
            }
            foreach (int amount in amounts)
                Console.WriteLine(amount);

            // Номер строки, в которой находится самая длинная серия одинаковых элементов.
            int number = 0;
            for (int i = 0; i < amounts.Count; i++)
            {
                if (amounts[i] > number)
                    number = i;
            }
            Console.WriteLine($"number = {number}");

            // Вывод в консоль начального массива.
            Console.WriteLine($"Исходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}, ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
