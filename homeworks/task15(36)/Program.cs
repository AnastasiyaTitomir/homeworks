// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] Array ()
{
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(0, 100);
    Console.Write(array[i]+" ");
}
return array;
}

int Count (int [] NewArray)
{
int result = 0;
for (int j = 2; j < NewArray.Length; j=j+2)
{
    result = NewArray[j] + result;
}
return result;
}
int [] FinalArray = Array(); 
Console.WriteLine(FinalArray);
Console.WriteLine("сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(Count(FinalArray));