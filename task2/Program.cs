﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.Write("Введите число А  ");
int number = Convert.ToInt32(Console.ReadLine());

int s = 0;
while (number > 0)
{
 
    s = s + number % 10;
    number = number /10 ;
 
}
 Console.WriteLine(s);