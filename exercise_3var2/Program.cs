//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру от 1 до 7:");
int number = int.Parse(Console.ReadLine());
const string Mon = "Понедельник";  // Ввела константу, которая хранит в себе название дня недели. Её нельзя поменять, в отличии от переменной.
const string Tue = "Вторник";
const string Wed = "Среда";
const string Thu = "Четверг";
const string Fri = "Пятница";
const string Sat = "Суббота";
const string Sun = "Воскресенье";

if (number == 1)
{                                  
Console.WriteLine($"Это не выхоной день: {Mon}");
}
else if (number == 2)
{                                  
Console.WriteLine($"Это не выхоной день: {Tue}");
}
else if  (number == 3)
{                                  
Console.WriteLine($"Это не выхоной день: {Wed}");
}
else if  (number == 4)
{                                  
Console.WriteLine($"Это не выхоной день: {Thu}");
}
else if  (number == 5)
{                                  
Console.WriteLine($"Это не выхоной день: {Fri}");
}
else if (number == 6)
{                                  
Console.WriteLine($"Это выхоной день: {Sat}");
}
else if (number == 7)
{                                  
Console.WriteLine($"Это выхоной день: {Sun}");
}
else   
{                            
Console.WriteLine("Вы ввели цифру не от 1 до 7");
}






