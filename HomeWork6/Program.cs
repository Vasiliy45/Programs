Console.WriteLine ("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=99) {
  Console.WriteLine ("третьей цифры нет");  
}
   else  {   Console.WriteLine("Третье число " + n.ToString()[2] );
   }
