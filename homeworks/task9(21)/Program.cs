// принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
double Ax, Ay, Az, Bx, By, Bz, distance; 

Console.WriteLine("Введите координаты точки А: "); 

Console.WriteLine("Введите координаты Аx: ");
Ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Аy: ");
Ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Аz: ");
Az = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите координаты точки B: "); 

Console.WriteLine("Введите координаты Bx: ");
Bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты By: ");
By = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Bz: ");
Bz = Convert.ToDouble(Console.ReadLine());


distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine("Расстояние между двумя точками в 3D пространстве равно " + Math.Round(distance, 2));