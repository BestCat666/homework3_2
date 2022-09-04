// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите трёхзначное число: ");

int num = int.Parse(Console.ReadLine());                                     
int ThirdDigit = num % 10;
if (num > 99 && num < 1000)
{                                  
Console.WriteLine($"Третья цифра: {ThirdDigit}");
}
else
{
Console.WriteLine("Вы ввели не трёхзначное число, не балуйтесь!");
}

