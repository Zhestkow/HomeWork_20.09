using static System.Console;
Clear();
WriteLine("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int n =10;
int i=1;
if (num < 100)
{
     WriteLine("нет третьего числа");
     return;
}
while (num%n!=num)
{
n=n*10;
i=i+1;
}
WriteLine($"третье число = {(num/(n/1000))%10}");

