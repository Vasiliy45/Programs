Console.WriteLine ("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= A)
{
    if (i % 2 == 0) 
    {
     Console.Write (i + ", ");
    }
      i++;
}