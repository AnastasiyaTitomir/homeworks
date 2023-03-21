// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// не получилось

int [] Array ()
{
int[] array = new int [4];
Console.Write("Первый массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(1, 10);
    Console.Write(array[i]+" ");
}
return array;
}



int [] Array1 = Array ();


int [] Array2 (int Array1)
{
Console.Write("Второй массив: ");
int zamena = 0;
for (int i = 0; i < Array1.Length; i++)
{
    zamena = Array1[i]*-1;
    Console.Write(zamena + " ");
}
 return zamena;  
}

Array2();



