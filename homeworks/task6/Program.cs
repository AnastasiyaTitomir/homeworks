// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.Write("input number ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (number>=-99 && number<=99)
{
    Console.Write("Третьей цифры нет");
}
else
{
    count = (number % 10);
    Console.WriteLine(count);
}

