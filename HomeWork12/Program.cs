Console.WriteLine ("Введите  число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  число B");
int b = Convert.ToInt32(Console.ReadLine());
double Step( int a, int b)
{
    double result = Math.Pow(a, b);
    
    Console.WriteLine ($" число  А  {a} в степени B {b} = {result}");
   
    return result;
    
}
Step (a,b);