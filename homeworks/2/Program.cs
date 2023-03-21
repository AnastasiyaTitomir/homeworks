// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, -3] -> да

// // не получилось

// int Prompt;
// {
// Console.WriteLine ("Введите числа:");
// return Convert.ToInt32(Console.ReadLine());
// }

// int massiv = Prompt;


// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [,] ChangeArray(int [,] matrix)
{
  int tmp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      tmp = matrix[0, j];
      matrix[0, j]= matrix [matrix.GetLength(0)-1,j];
      matrix [matrix.GetLength(0)-1,j] = tmp;
   }
   return matrix;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
PrintArray(ChangeArray(matrix));

// задача. двумерный массив. поменять местами столбцы и строчки.

int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = m;
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [,] ChangeArray(int [,] matrix)
{
  int [,] newArray = new int [matrix.GetLength(1), matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[i, j]= matrix [j,i];
     }
  }
  return newArray;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
PrintArray(ChangeArray(matrix));





//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.



int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [] Array(int [,] matrix)
{
  int k =0;
  int [] newArray = new int [matrix.GetLength(0)*matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[k]= matrix [i,j];
      k++;
     }
  }
  return newArray;
}


int [] SortArray(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array [minPosition])
        {
            minPosition = j;
        }
    }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}
return array;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
int [] newArray = Array(matrix);
Console.WriteLine(String.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine(String.Join(", ", newArray));

int el = newArray[0];
int count = 1;
for (int i = 1; i < newArray.Length; i++)
{
    if (el == newArray[i])
    {
      count ++;
    }
    else
    {
      Console.WriteLine($"Число {el} встречается в массиве {count} раз");
      count = 1;
      el = newArray[i];
    }
}
Console.WriteLine($"Число {el} встречается в массиве {count} раз");