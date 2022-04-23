/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Введите число А  ");
string? number = Console.ReadLine();
int sum = 0;
for (int index = 0;index<number.Length;index++)
{
    sum = sum + Convert.ToInt32(number[index]);
    
}
Console.WriteLine(sum);

/*int s = 0;
while (number > 0)
{
 
    s = s + number % 10;
    number = number /10 ;
 
}
 Console.WriteLine(s);*/


