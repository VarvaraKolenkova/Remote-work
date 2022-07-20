// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
int number = new Random().Next(100,1000);
System.Console.WriteLine(number);

int a1 = number%10;
int a2 = number/10%10;
int a3 = number/100%10; 
System.Console.WriteLine(""+a3+""+a1);