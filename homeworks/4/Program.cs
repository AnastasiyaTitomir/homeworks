// выводит случайное трехзначное число и удаляет  вторую цифру этого числа (2 семинар, в залах)

int Random = new Random().Next(100, 1000);
Console.WriteLine("случайное трехзначное число:  " +Random);

int number1 = Random/100;
int number3 = Random%10;

Console.WriteLine("Новое число:  {0}{1}", number1, number3);

