// принимает на вход три числа и выдаёт максимальное из этих чисел

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2 & num1>num3)
{
    Console.Write(num1+" is biggest");
}
if (num2>num1 & num2>num3)
{
     Console.Write(num2+" is biggest");
}
if (num3>num1 & num3>num2)
{
     Console.Write(num3+" is biggest");
}    