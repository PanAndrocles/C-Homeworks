// Задача 2. Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
int max = 0;
int min = 0;

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
 max = num1;
 min = num2;
}
else
{
max = num2;
min = num1;
}

Console.WriteLine($"{max} is the biggest number and {min} is the smallest number");

*/

// Задача 4. Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine($"{max} is biggest number");

*/

// Задача 6. Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

if(result == 0)
{
    Console.WriteLine($"{num} is even number");
}

else
{
    Console.WriteLine($"{num} is odd number");
}

*/

// Задача 8. Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
if (i % 2 == 0)
Console.Write(i + ",");
}