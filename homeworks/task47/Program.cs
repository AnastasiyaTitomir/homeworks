//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// вопрос -  как сделать вывод чисел с запятой, не прибегая к умножению на 0,2 (строка 22)

int PriglasitKVvodu (string text)
{
Console.WriteLine (text);
return Convert.ToInt32(Console.ReadLine());
}

double [,] CreateArray (int a, int b)
{
    double [,] array = new double [a,b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
          array [i,j]= Math.Round((new Random().Next(-100,100)*0.2),3);
        
          Console.Write(array[i,j] + " || ");
       }
       Console.WriteLine();
    }
    return array;
}

int a = PriglasitKVvodu ("Введите количество строк: ");
int b = PriglasitKVvodu ("Введите количество столбцов: ");
Console.WriteLine();
CreateArray (a,b);