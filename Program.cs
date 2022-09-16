//Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел
Console.Write("введите первое число: ");
int num1;
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int num3;
num3 = Convert.ToInt32(Console.ReadLine());
if (num2<num1 & num3<num1) Console.WriteLine($"max =  {num1}" );
else if (num1<num2 & num3<num2) Console.WriteLine($"max =  {num2}" );
else if (num1<num3 & num2<num3) Console.WriteLine($"max =  {num3}" );