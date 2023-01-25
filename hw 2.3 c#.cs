/*
Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели > ");
string? dayweek = Console.ReadLine();
int numbday = Convert.ToInt32(dayweek);

bool Solution(int num)
{
    if(num > 0 && num < 8)
    {
        return true;
    }
    System.Console.WriteLine("Ошибка!");
    return false;
}

if (Solution(numbday))
{
    if(numbday == 6 | numbday == 7)
    {
        System.Console.WriteLine("Этот день является выходным!");
    }
    else System.Console.WriteLine("Этот день не является выходным!");
}