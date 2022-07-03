Console.WriteLine ("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int [] calkule (int num)
{
  int[] A =new int [num];
  int i=1;
  while (i <= num) {
    A [i-1]=i*i*i;
    Console.WriteLine (A[i-1]);
    i++;}
    return A;
   
}
int [] resault = calkule(n);
