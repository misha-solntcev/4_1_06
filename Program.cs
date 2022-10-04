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
                { 8, 0, 6, -4, 0 },
                { 4, 1, 6, 7, 8 },
                { 7, 8, 8, 8, 2 },
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

            // Номер строки, в которой находится самая длинная серия одинаковых элементов.
            List<int> maxAmounts = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int maxAmount = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int amount = 0;
                    int temp = array[i,j];
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[i,k] == temp)
                            amount++;
                    }
                    if (amount > maxAmount)
                        maxAmount = amount;
                }
                maxAmounts.Add(maxAmount);
            }
            int number = 0;
            for (int i = 0; i < maxAmounts.Count; i++)
            {
                if (maxAmounts[i] > number)
                    number = i;
            }
            Console.WriteLine($"number = {number}");
            Console.ReadKey();
        }
    }
}
