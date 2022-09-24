// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите точку A(x,y,z) :");
double[]t1=new double[3]{Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Введите точку B(x,y,z) :");
double[]t2=new double[3]{Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
double Lx= Math.Pow((t2[0]-t1[0]),2);
double Ly= Math.Pow((t2[1]-t1[1]),2);
double Lz= Math.Pow((t2[2]-t1[2]),2);
double L= Math.Sqrt(Lx+Ly+Lz);
Console.WriteLine($"Длина = {L= Math.Round(L,2)}");