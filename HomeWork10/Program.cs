Console.WriteLine ("Введите пятизначное число");

int N = Convert.ToInt32(Console.ReadLine());
if ( N<10000 || N>100000) 
{
 Console.WriteLine ("Число введено не правильно");   
} else {
int a = (N%10)/1;
int c = (N%100)/10;
//int a = (N%1000)/100;
int d = (N%10000)/1000;
int b = (N%100000)/10000;
if (a==b && c==d){
    Console.WriteLine ("Число палиндром");
} else Console.WriteLine ("Число не палиндром");
}