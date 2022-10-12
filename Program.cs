/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num<10000 && num>100000) Console.WriteLine("Число не является пятизначным");
string str = num.ToString();
Console.WriteLine(str[2]);
