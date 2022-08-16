using System;
using System.Collections.Generic;
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
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        public string CapitalizeString(string str)
        {
            str = Regex.Replace(str, @"[a-z]", element => element.ToString().ToUpper());
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
