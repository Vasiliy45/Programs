Console.WriteLine ("Введите координаты точки x1");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки y1");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки z1");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки x2");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки y2");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки z2");
int Zb = Convert.ToInt32(Console.ReadLine());
   
double Num (double x1, double y1, double z1, double x2, double y2, double z2)
{
   
double rast = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));

    return rast;
}
double a= Num (Xa,Ya,Za,Xb,Yb,Zb);
Console.WriteLine(a);
