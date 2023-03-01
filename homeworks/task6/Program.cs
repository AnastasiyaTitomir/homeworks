// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.Write("input number ");
int number = Convert.ToInt32(Console.ReadLine());


// if (number>=-99 && number<=99)
// {
//     Console.Write("Третьей цифры нет");
// }
// else
// {
//     count = (number % 10);
//     Console.WriteLine(count);
// }

if (number > 1000) 
{ 
    while(number > 999) 
    { 
        number /= 10; 
    } 
    Console.WriteLine(number % 10); 
} else 
if (number < 99) 
{ 
    Console.WriteLine("Третьей цифры в числе нет!"); 
} 
else 
{ 
    Console.WriteLine(number % 10); 
}
