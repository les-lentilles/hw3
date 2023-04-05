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


// Задача 21. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"d = {d}");



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[]result = new int[N];
for (int i = 1; i <= N; i++)
    result [i - 1] = i * i * i;
for (int i = 0; i < N; i++)
    Console.Write($"{result[i]} ");