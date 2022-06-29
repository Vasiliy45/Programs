 int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}


int a1=15;
int a2=17;
int a3=14;
int b1=1008;
int b2=20;
int b3=22;
int c1=28;
int c2=300;
int c3=29;


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine( max + " большее число");
