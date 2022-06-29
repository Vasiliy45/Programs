/*Console.WriteLine ("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int summ = numberA*numberA;
Console.WriteLine(summ);*/

/*Console.WriteLine ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
  Console.WriteLine ("Является квадатом числа");

} else 
{
    Console.WriteLine ("Не является квадратом");
}*/

Console.WriteLine ("Введите номер дня");
int A = Convert.ToInt32(Console.ReadLine());
if (A == 1) {
  Console.WriteLine ("понедельник");  
}
if (A == 2) {
  Console.WriteLine ("вторник");  
}
if (A == 3) {
  Console.WriteLine ("среда");  
}
if (A == 4) {
  Console.WriteLine ("четверг");  
}
if (A == 5) {
  Console.WriteLine ("пятница");  
}
if (A == 6) {
  Console.WriteLine ("суббота");  
}
if (A == 7) {
  Console.WriteLine ("воскресенье");  
} else {Console.WriteLine ("ошибка");}
