/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ((100<=number) && (number<=999))
{
    Console.WriteLine((number/10)%10);
} else
{
    Console.WriteLine("Неверно ввели число");
}