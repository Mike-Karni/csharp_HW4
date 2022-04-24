/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Введите число А  ");
string number = Console.ReadLine();
int sum = 0;
for (int index = 0;index<number.Length;index++)
{
    string strnumb = Convert.ToString(number[index]);
    sum = sum + Convert.ToInt16(strnumb);
}
Console.WriteLine(sum);


//Второе решение
/*int summ = 0;
while (number > 0)
{
     summ = summ + number % 10;
    number = number /10 ;
 }
 Console.WriteLine(summ);*/


