//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using static System.Console;
Clear();

int a = Convert.ToInt32(ReadLine());

WriteLine(a / 10 < 10 ? "Число не является трехзначным" : a / 10 % 10);



