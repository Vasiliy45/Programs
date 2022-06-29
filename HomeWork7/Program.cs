Console.WriteLine ("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day<1 || day >7) 
{
Console.WriteLine ("таких дней нет");
} else if (day == 6 || day==7 ) {
   Console.WriteLine ("день выходной"); 
} else {
    Console.WriteLine ("работать негры");
}