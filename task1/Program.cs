// Задача 19. Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void palindrom()
{
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;
int total = number / 10000;
        
if (total < 1 || total > 9)
{
     Console.WriteLine($"Пожалуйста, введите правильное число");
}
else if  (num1 == num5 && num2 == num4)
{
     Console.WriteLine($"Ваше число: {number} - палиндром.");
}
else
{
    Console.WriteLine($"Ваше число: {number} - не палиндром.");
}
}
for (int i = 0; i < 10; i++)
{ 
palindrom();
}