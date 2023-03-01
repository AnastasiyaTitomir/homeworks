// принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
using System;
Console.Write("input number ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int akk = 0;

if (number>=100 && number<1000)
{
    count = (number % 100);
    akk = (count / 10);

    Console.WriteLine(akk);
}
else
{
    Console.Write("введите трехзначное число!");
}
