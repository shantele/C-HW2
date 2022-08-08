// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер, обозначающий день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 7 || dayNumber < 1)
{
    Console.WriteLine("Такого дня недели нет.");
}
else
{
    if (dayNumber <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной день");
    }
}