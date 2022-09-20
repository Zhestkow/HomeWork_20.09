using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int num=Convert.ToInt32(ReadLine());
int num1 = num/10%10;
WriteLine($"второе число числа {num} это {num1}");