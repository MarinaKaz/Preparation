using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/*4.Написать метод, который принимает массив значений int и сортирует его пузырьком. Написать, а не разобрать! 
5. Написать свой метод, не используя библиотеки, чтобы перевести строку, содержащую цифры и буквы (английского алфавита) 
в верхний регистр, т.е. "asF1dA" -> "ASF1DA". Всякие штуки вида string.toUpper - не использовать, написать логику самой.*/
namespace ConsoleApp1
{
    class NumbersAndStrings
    {
        public int[] BubbleSort(int[] numbers)
        {
            int temp;
            for (int k = 0; k <= numbers.Length - 2; k++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }

        public string CapitalizeString(string str, string pathToFile)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in File.ReadAllLines(pathToFile))
            dictionary.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

            str = Regex.Replace(str, @"[a-z]", element => dictionary[element.ToString()]);
            return str;
        }

        public void FindMinAndMaxDigit(int num, out int min, out int max)
        {
            min = 9;
            max = 0;            
            while (num != 0)
            {
                int digit = num % 10;
                max = Math.Max(digit, max);
                min = Math.Min(digit, min);
                num = num / 10;
            }
        }
    }
}
