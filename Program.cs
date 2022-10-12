/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine()!);
string str = num.ToString();

int num0= str[0];
int num4= str[4];
int num1= str[1];
int num3= str[3];

if (num0==num4 && num1==num3) Console.WriteLine("ПАЛИНДРОМ");
 
else
    Console.WriteLine("Число не является палиндромом");
    





