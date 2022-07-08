string num = "2342";
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    int number = Convert.ToInt32(num[i].ToString());
    sum += number;
}
Console.WriteLine(sum);
