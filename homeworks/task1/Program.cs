// на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System;
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write(num1+" is smaller");
}
else
{
    Console.Write(num2+" is bigger");
}

