// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: "); 
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int [4];

if (num>9999 && num<100000)
{
string text = Convert.ToString(num);
       if(text[0]==text[4] && text[1]==text[3])
            {
                Console.WriteLine(text + "- это палиндром");
            }
        else
            {
                Console.WriteLine(text + "- это не палиндром");
            }
 }
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
} 

//  Console.WriteLine("Не удалось распознать число");