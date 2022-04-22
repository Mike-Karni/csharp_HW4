/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
// Сделал две функции на ввод чисел
int InputNumberA(string A)
{
    Console.Write("Введите число А  ");
    return Convert.ToInt32(Console.ReadLine());
}
int InputNumberB(string B)
{
    Console.Write("Введите число B  ");
    return Convert.ToInt32(Console.ReadLine());
}

int a = InputNumberA("A");
int b = InputNumberB("B");
int stepen = 1;
for (int i = 1; i<=b;i++)
{
    stepen = stepen*a;
}
Console.WriteLine($"Результатом возведения  числа {a} в степень {b} является число {stepen} " );