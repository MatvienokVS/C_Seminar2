//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

//Ввод пользоватлем
int a = Convert.ToInt32(ReadLine());
WriteLine(a / 10 < 10 || a / 10 > 99 ? "Пользователь ввёл число не трехзначное!!!" : $"Третья цифра числа, выбранного пользователем равна {a % 10}");
WriteLine();


//Модификация к условию задачи

//Случайный выбор
int b = new Random().Next(100, 1000);
WriteLine($"Случайным способом выбрано трехзначное число {b}");
WriteLine($"Третья цифра выбранного числа равна {b % 10}");


//Сравнение третих чисел введённых разным способом.
WriteLine();
WriteLine(a == b ? "Последние цифры введённых числе равны" : "Последние цифры введённых числе не равны");
