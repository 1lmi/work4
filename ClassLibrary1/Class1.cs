using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // Метод для подсчёта суммы всех нечётных чисел
        public int CulcOddNums(int[,] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] % 2 != 0) 
                    {
                        sum += nums[i, j];
                    }
                }
            }
            return sum;
        }

        // Метод для подсчёта суммы всех элементов массива
        public int SumAllElements(int[,] nums)
        {
            int totalSum = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    totalSum += nums[i, j];
                }
            }
            return totalSum;
        }

        // Метод для подсчёта количества элементов больше среднего значения
        public int CountElementsGreaterThanAverage(int[,] nums)
        {
            int totalSum = SumAllElements(nums); // Используем метод для подсчёта общей суммы
            int totalElements = nums.GetLength(0) * nums.GetLength(1); // Количество элементов в массиве
            double average = (double)totalSum / totalElements; // Среднее значение

            int count = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] > average)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
