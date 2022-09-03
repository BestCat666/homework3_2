//  Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

int num = int.Parse(Console.ReadLine());                                     
int FirstDigit = num/100;
int SecondDigit = (num - FirstDigit * 100) /10; 
int ThirdDigit = (num - FirstDigit * 100 - SecondDigit * 10); // примр для себя,можно было это не писать
if (num > 99 && num < 1000)
{                                  
Console.WriteLine($"Второе число: {SecondDigit}");
}
else
{
Console.WriteLine("Вы ввели не трёхзначное число, не балуйтесь!");
}

