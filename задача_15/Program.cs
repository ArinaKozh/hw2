/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if ((day>0) && (day<6))
{
    Console.WriteLine("нет");
} else if ((day>5) && (day<8))
{
    Console.WriteLine("да");
} else Console.WriteLine("Не день недели");
