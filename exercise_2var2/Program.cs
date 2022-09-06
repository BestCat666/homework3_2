// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int digit = num.ToString().Length;

if  (digit  < 3 )
{
    Console.WriteLine("В введённом числе нет третьей цифры");
}
else
{
    string stringNumber = Convert.ToString(num);
    Console.Write($"третья цифра в ведённом числе: {stringNumber[2]}");
}