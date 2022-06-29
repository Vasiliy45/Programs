int [] mass = {1, 2, 3, 4, 8, 5, 6, 4, 8, 9};
int n = mass.Length;
int find = 4;
int index = 0;
while(index<n)
{
    if (mass [index] ==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}