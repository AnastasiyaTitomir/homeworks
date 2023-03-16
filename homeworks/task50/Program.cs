// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int PriglasitKVvodu (string text)
{
Console.WriteLine (text);
return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateArray (int a, int b)
{
    int [,] array = new int [a,b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
          array [i,j]= new Random().Next(0,10);
        
          Console.Write(array[i,j] + " || ");
       }
       Console.WriteLine();
    }
    return array;
}

int PoiskChislaPoindeksam (int indexA, int indexB, int[,] newArray)
{  
   if (indexA>=newArray.GetLength(0) && indexB>=newArray.GetLength(1))
         {
            Console.WriteLine("Такого числа в массиве не существует");
         }

   int chislo = newArray[indexA, indexB];
          if (indexA<=newArray.GetLength(0) && indexB<=newArray.GetLength(1))
          {
             Console.WriteLine("Найденное число: " +chislo);
          }       
   return chislo;
}

int a = PriglasitKVvodu ("Введите количество строк массива: ");
int b = PriglasitKVvodu ("Введите количество стотлбцов массива: ");
int [,] newArray = CreateArray (a,b);
Console.WriteLine();

int indexA = PriglasitKVvodu ("Введите номер строки: ");
int indexB = PriglasitKVvodu ("Введите номер столбца: ");

PoiskChislaPoindeksam (indexA, indexB, newArray);

Console.WriteLine();
