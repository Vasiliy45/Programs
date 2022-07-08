int [] arr(int N)
{
int [] resalt = new int [N];
for(int i=0; i<N; i++)
{
    int A= (new Random()).Next(0,10); 
    resalt[i]= A;
   Console.Write(resalt[i]+" ");
}
return resalt;
}
arr (8);
