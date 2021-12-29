using System;
using System.Collections.Generic;

namespace ArraysListsEnums
{
    class Program
    {
        enum Days //перечисление
        {   
            Mon = 10,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun
        }

        static void Main(string[] args)
        {

            int[] array = new int[10]; //создать целочисленный одномерный массив из 10 чисел
            int[,] matrix = new int[10, 10]; // создать целочисленный двумерный массив из 10 чисел
            //int[,,] wtf = new int[10, 10, 10]; //создать целочисленный трёхмерный массив из 10 чисел

            array[0] = 1; //1
            array[9] = 5; //10

            matrix[0, 0] = 1;
            matrix[9, 9] = 9;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" "); //вывод массива без переноса строки
            }
            //*****************************************************************************************************************************
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++) // вывод матрицы
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //  GetLength - Определение длины ряда\столбца 0ряд 1столбец
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();

            }

            //*****************************************************************************************************************************

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Число: {matrix[0,0]}\nЕщё число: {matrix[9,9]}"); //для вывода переменных в строке добавить $ и {var}

            //*****************************************************************************************************************************

            List<int> list = new List<int>(); //создание пустого списка

            list.Add(0);
            list.Add(1);
            list.Add(2);

            for (int i = 0; i < list.Count; i++) //вывод листа
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            //*****************************************************************************************************************************

            Console.WriteLine(12-Days.Mon);

            //*****************************************************************************************************************************

            List<int> list2 = new List<int>() // ввод списка сразу
            {
                1,2,3,4,5,6,7
            };

            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]+" ");
            }
        }
    }
}
    