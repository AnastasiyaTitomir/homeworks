// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] Array ()
{
double[] array = new double [8];
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(0, 1000);
    Console.Write(array[i]+" ");    
}
return array;
}

double Max (double [] NewArray)
{
double max = NewArray[0];

for (int i = 1; i < NewArray.Length; i++)
{
    if (max < NewArray[i])
    {
       max = NewArray[i];
    }
}
return max;
}

double Min (double [] NewArray)
{
double min = NewArray[0];

for (int i = 1; i < NewArray.Length; i++)
{
    if (min > NewArray[i])
    {
       min = NewArray[i];
    }
}
return min;
}
double [] FinalArray = Array(); 
double sum = Max(FinalArray)-Min(FinalArray);
Console.WriteLine("  ");
Console.WriteLine("разница между максимальным и минимальным элементом массива:" +sum);


