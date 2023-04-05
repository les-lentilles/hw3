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
int num3 = number / 10 % 10;
int num4 = number % 10;
int num5 = number / 10000;
        
if (num5 < 1 || num5 > 9)
{
Console.WriteLine(number + " -> " + "Not 5-digit number");
}
else if  (num1 == num4 && num2 == num3)
{
Console.WriteLine(number + " -> Yes, this is palindrom");
}
else
{
Console.WriteLine(number + " -> No, this is not palindrom");
}
}
for (int i = 0; i < 10; i++)
{ 
palindrom();
}