// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] Array ()
{
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(100, 1000);
    Console.WriteLine(array[i]+" ");
}
return array;
}

int Count (int [] finalArray)
{
   int num = 0;
    for (int j = 0; j < finalArray.Length; j++)
    {
        if (finalArray[j]%2==0)
        num++;
    }
    return num;
}
Console.WriteLine(Count(Array()));