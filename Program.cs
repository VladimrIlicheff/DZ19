/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num < 10000) ;
else if (num > 100000) ;
Console.WriteLine("Число не является пятизначным");
string str = num.ToString();

if(str[0] == str[4]) ;
else if(str[1] == str[3]) ;
Console.WriteLine("Число является ПАЛИНДРОМОМ");
else
    Console.WriteLine("Число не является палиндромом");

