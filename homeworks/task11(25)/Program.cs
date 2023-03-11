// ринимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("введите число А");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число В");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB>0)
    Console.WriteLine("ответ: " + Math.Pow(numA, numB));

else
    Console.WriteLine("введите натуральное число В");