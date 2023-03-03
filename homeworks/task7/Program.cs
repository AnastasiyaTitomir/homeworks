// принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели"); 
int number = Convert.ToInt32(Console.ReadLine());

if (number>5 && number<8)
{
    Console.WriteLine("Выходной"); 
}
else
{
    Console.WriteLine("Дня с такой цифрой не существует или будний"); 
}

