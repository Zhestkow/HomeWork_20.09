using static System.Console;
Clear();
WriteLine("Введите число: ");
int Day= int.Parse(ReadLine()!);
string dayweek = Day==6|| Day== 7?"выходной":"будний";
WriteLine(dayweek);