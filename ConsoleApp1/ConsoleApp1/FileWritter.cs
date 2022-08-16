using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/*1.есть 1 файл на диске InputText.txt с некоторым текстом (предположим, на русском языке - можешь взять любой текст с интернета - пару абзацев). 
    Написать метод, который считывает этот файл, затем разделяет текст на предложения и каждое предложение выводит в отдельный файл с именем OutputText_NNN.txt 
    (NNN - это трехзначный номер по порядку файла), т.е.в итоге первое предложение из исходного файла выводится в файл OutpuText_001.txt, второе - в OutputText_002.txt и т.д.

2. Есть произвольное число текстовых файлов с текстом, Нужно написать метод который принимает любое число путей к этим файлам, считывает из них текст и выводит его в некий 1 общий файл.
Т.е. я могу передать в этот метод путь к 1 файлу или к 4, или к 10, но этот метод должен отработать с любым количеством файлов.
*/

namespace ConsoleApp1

{
    class FileWritter
    {
        public void SplitFileBySentence(string path, string outputFilePath)
        {
            using (StreamReader str = new StreamReader(path))
            {
                string line = str.ReadToEnd();
                string[] sentences = line.Split('.');
                for (int i = 0; i < sentences.Length; i++)
                {
                    if (!string.IsNullOrEmpty(sentences[i]))
                    {
                        string outputFilePathWithName = outputFilePath + "\\OutputText_" + ((i + 1).ToString()).PadLeft(3, '0') + ".txt";
                        using (StreamWriter writer = new StreamWriter(outputFilePathWithName))
                        {
                            writer.WriteLine(sentences[i]);
                        }
                    }
                }
            }
        }

        public void JoinFiles(List<string> filesList, string outputFile)
        {
            string allData = "";
            foreach (string file in filesList)
            {
                using (StreamReader str = new StreamReader(file))
                {
                    string fileContent = str.ReadToEnd();
                    allData += fileContent;
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(allData);
            }
        }
    }
}
