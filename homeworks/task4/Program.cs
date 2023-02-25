// на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("input number ");

Double number = Convert.ToInt32(Console.ReadLine());

for (Double i = 2; i <= number; i++)
{
    if (i%2==0)
    {
        Console.Write(i);
    }
}

