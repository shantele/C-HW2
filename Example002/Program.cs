// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
else
{
    string stringNumber = Convert.ToString(number);                     // string str = Convert.ToString(num); ->
    Console.WriteLine("Третья цифра числа: " + stringNumber[2]);       //  конвертирование числа в строку

}