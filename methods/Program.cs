﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{


    class Program
    {
        #region Задание 1. Метод разделения строки на слова
        /// <summary>
        /// Преобразует строку в массив строк
        /// </summary>
        /// <param name="InWorld"></param>
        /// <returns>Возвращает массив строк</returns>
        static string[] SplitWords(string inWorld)
        {
            string[] ArrayWords = inWorld.Split(' ');
            return ArrayWords;
        }
        /// <summary>
        /// Печатет массив строк
        /// </summary>
        /// <param name="InArray"></param>
        static void PrintingArray (string[] inArray)
        {
            foreach (var s in inArray)
            {
                Console.Write($"\n{s}");
            }
            Console.ReadLine();
        }
        #endregion
        #region Задание 2. Перестановка слов в предложении
        /// <summary>
        /// Принимает массив строк и меняет слова местами в обратной последовательности.
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns>Возвращает обратный массив</returns>
        static string[] ReversWords(string inputPhrase)
        {
            string[] ArrayWords = SplitWords(inputPhrase);
            int lenght = ArrayWords.Length;
            string[] ReverseArr = new string[lenght];
            for (int i = 0; i < lenght; i++)
            {
                ReverseArr[i] = ArrayWords[lenght-i-1];
            }
            return ReverseArr;

        }
        #endregion
        static void Main(string[] args)
        {
            string task1 = "Задание 1. Метод разделения строки на слова";
            string task2 = "Задание 2. Перестановка слов в предложении";

            string tasksPattern = "Выберите задание: \n{0} \n{1}";

            Console.WriteLine(tasksPattern
                              , task1
                              , task2);
            int Choise = int.Parse(Console.ReadLine());

            switch (Choise) {
                case 1:
                    Console.WriteLine("Введите предложение:");
                    string[] ArrayWords = SplitWords(Console.ReadLine());
                    PrintingArray(ArrayWords);
                    break;
                default:
                    Console.WriteLine("Введите предложение:");
                    string[] ArrWords = ReversWords(Console.ReadLine());
                    PrintingArray(ArrWords); 
                    break;
            
            }  
        }
    }
}
