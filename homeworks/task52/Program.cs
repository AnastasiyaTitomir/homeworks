// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double Count (int [,] array)
{   
  double count = 0; 
  for (int i = 0; i < array.GetLength(1); i++)   
  {     
    for (int j = 0; j < array.GetLength(0); j++)    
    {      
  
     count =  count + array[j,i];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i}: " + Math.Round((count / array.GetLength(0)),2));   
    count = 0;
   }
return count; 
}
    
int a = PriglasitKVvodu ("Введите количество строк: ");
int b = PriglasitKVvodu ("Введите количество столбцов: ");
Console.WriteLine();
int [,] array = CreateArray (a,b);
Count (array);
