// сама сделала неверно. Переделать, т.к. списала.

//принимает на вход число и выдаёт сумму цифр в числе

int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt();

int summa = 0;

while (number>0)
{
summa = summa + number%10;
number /= 10;
}
Console.WriteLine($"сумма цифр в числе: {summa}");


// int delitel = 10;
// int count = 0;
// int summa = 0;

//     if (number!=0)
//     {
//         while (number>0)
//         {
//         count = number % delitel;
//         summa = count + summa; 
//         delitel *= 10;
//         number = number/10;
//         }
//         Console.WriteLine(summa);
//     }
//     else
//     {
//      Console.WriteLine("ошибка ввода ");   
//     }
    

