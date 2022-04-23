/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Введите число А  ");
int number = Convert.ToInt32(Console.ReadLine());

string number1 = Convert.ToString(number);
int sum = 0;
int index = 0;

while (index<number1.Length)
{
    sum = sum + Convert.ToInt32(number1[index]);
    index++;
    Console.WriteLine(sum);
    Console.WriteLine(number1[index]);
}
Console.WriteLine(sum);




/*int s = 0;
while (number > 0)
{
 
    s = s + number % 10;
    number = number /10 ;
 
}
 Console.WriteLine(s);*/


// 111111111
/*int number = RandomInt(100,1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[0]}{stringNumber[2]}");

/*int RandomInt(int enclusiveMin,int exclusiveMax)
{
    return new Random().Next(enclusiveMin,exclusiveMax);
}*/