int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}


int [] mass = {1,2,3,45,5,6,7,8,9};


int max = Max(Max(mass[0], mass[1], mass[2]), Max(mass[3], mass[4], mass[5]), Max(mass[6], mass[7], mass[8]));
Console.WriteLine( max + " большее число");
