//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7:");
int number = int.Parse(Console.ReadLine());
int Mon = 1;
int Tue = 2;
int Wed = 3;
int Thu = 4;
int Fri = 5;
int Sat = 6;
int Sun = 7;
if (number  > 5 && number < 8)
{                                  
Console.WriteLine("Это выходной день");
}
else
{
Console.WriteLine("Не выхоной");
}