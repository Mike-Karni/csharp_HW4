﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)*/

Console.WriteLine("Введите значения массива через запятую");

string array = Console.ReadLine();

int index = 0;
while(index<array.Length)
{
    Console.Write( array[index]+ " ");
    index+=2 ;
}

//Console.WriteLine(dlina);

/*int[] array = new int [8];

void FilArray(int[] collection)
{ 
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] massiv)
{
      int count = massiv.Length;
      int position = 0;
      while (position<count)
      {
          Console.Write(massiv[position]);
          position++;
      }

}
FilArray(array);
PrintArray(array);*/