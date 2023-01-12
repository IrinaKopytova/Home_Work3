// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string N = Convert.ToString(Console.ReadLine());

if (N.Length == 5)
{
if (N[0]==N[4] && N[1]==N[3])
  {
    Console.WriteLine("Ваше число - палиндром");
  }
  else  
  Console.WriteLine("Ваше число - НЕ палиндром");
}
else 
{
    Console.WriteLine("Введено не пятизначное число");
}
