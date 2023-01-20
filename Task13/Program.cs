/*
Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
int[] mus = new int[anyNumberText.Length];
int num = 0;
int i = anyNumberText.Length - 1;

if (anyNumber > 99)
{
    while (anyNumber != 0)
    {
        num = anyNumber % 10;
        anyNumber = anyNumber / 10;
        mus[i] = num;
        i--;
    }
    System.Console.WriteLine("Третья цифра = " + mus[2]);
}
else System.Console.WriteLine("Третьей цифры нет");