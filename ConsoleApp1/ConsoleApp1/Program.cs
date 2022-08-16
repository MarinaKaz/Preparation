using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            string filePath = "D:\\job\\1\\IsSoft\\Preparation\\ConsoleApp1\\input\\InputText.txt";
            string outputFilePath = "D:\\job\\1\\IsSoft\\Preparation\\ConsoleApp1\\output";
            new FileWritter().SplitFileBySentence(filePath, outputFilePath);

            //task2
            List<string> fileList = new List<string> { "D:\\job\\1\\IsSoft\\Preparation\\ConsoleApp1\\output\\OutputText_002.txt", "D:\\job\\1\\IsSoft\\Preparation\\ConsoleApp1\\output\\OutputText_004.txt" };
            string outputFile = "D:\\job\\1\\IsSoft\\Preparation\\ConsoleApp1\\input\\OutputFileWithAllContext.txt";
            new FileWritter().JoinFiles(fileList, outputFile);

            //task3
            var a = new Human(182, "Blue", "M");
            a.Clone();
           
            //task4
            int[] array = { 5, 1, 3, 9, 10 };
            var sortArray = new NumbersAndStrings().BubbleSort(array);
            Console.WriteLine("Sorted array = [{0}]", string.Join(", ", sortArray));

            //task5
            string anyString = "asF1dA";
            Console.WriteLine(new NumbersAndStrings().CapitalizeString(anyString));

            //task6
            int anyNumber = 4623187;
            new NumbersAndStrings().FindMinAndMaxDigit(anyNumber, out int minDigit, out int maxDigit);
            Console.WriteLine($"Min digit: {minDigit}, Max digit: {maxDigit}");
        }
    }
}
