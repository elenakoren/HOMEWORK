/*Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел */

Console.WriteLine("Введите первое число");
string numberOneStr = Console.ReadLine();
Console.WriteLine("Введите второе число");
string numberTwoStr= Console.ReadLine();
Console.WriteLine("Введите третье число");
string numberThreeStr = Console.ReadLine();

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo= Convert.ToInt32(numberTwoStr);
int numberThree = Convert.ToInt32(numberThreeStr);

int max=numberOne;
if (numberTwo>max)
Console.WriteLine($"{numberTwo}");
if (numberThree>max)
Console.WriteLine($"{numberThree}");

