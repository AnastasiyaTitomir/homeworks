// выводит случайное число от 10 до 99 и показывет наибольшую цифру (2 семинар, 20 минута)

// списала

int Random = new Random().Next(10, 100);
Console.WriteLine("случайное число от 10 до 99:  " +Random);

int max = Random/10;
int min = Random%10;

    if (max>min)
    Console.WriteLine("Наибольшая цифра: {0}", max);
    else Console.WriteLine("Наибольшая цифра: {0}", min);