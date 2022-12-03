/* Напишите программу, которая на вход принимает число (N), 
 a на выходе показывает все четные числа от 1 до N.*/

Console.WriteLine("Введите число");
string numberStr=Console.ReadLine();
int number=Convert.ToInt32(numberStr);

for(int i=1; i<=number; i++)

     if (i % 2 == 0)
     Console.Write($"{i},");
