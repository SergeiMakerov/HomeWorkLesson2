/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите цифру дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 6 || dayNum == 7)
{
    Console.WriteLine(" -> да");
}
else if (dayNum < 1 || dayNum > 7)
{
    Console.WriteLine("Это не день недели");
}
else Console.WriteLine(" -> нет");