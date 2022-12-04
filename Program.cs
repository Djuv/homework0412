/*ДЗ
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 5;
int b = 3;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;

Console.Write("max = ");
Console.WriteLine(max); 


Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 2;
int b = 3;
int c = 7;

int max = c;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("max = ");
Console.WriteLine(max);



 ЗАДАЧА 6 : Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 2 == 0)
{
  Console.WriteLine("Yes!");
}
else 
{
  Console.WriteLine("No!");
}


Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 0;

while(current <= num)
{
  Console.Write(current + " ");
  current ++;

if(num % 2 == 0)

  Console.WriteLine(current);
}
*/
