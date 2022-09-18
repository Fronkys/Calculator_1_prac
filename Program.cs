Console.WriteLine("1.Сложить 2 числа");
Console.WriteLine("2.Вычесть первое из второго");
Console.WriteLine("3.Перемножить два числа");
Console.WriteLine("4.Разделить первое на второе");
Console.WriteLine("5.Возвести в степень N первое число");
Console.WriteLine("6.Найти квадратный корень из числа");
Console.WriteLine("7.Найти 1 процент от числа");
Console.WriteLine("8.Найти факториал из числа");
Console.WriteLine("9.Выйти из программы");

string Povtor = "yes";

do
{
Console.WriteLine("Введите число от 1 до 9");
int ChisloAmount = Convert.ToInt32(Console.ReadLine());

if (ChisloAmount == 1)
{

Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Итог: ");
Console.WriteLine(x + y);

}

else if (ChisloAmount == 2)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
Double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Итог: ");
Console.WriteLine(x - y);

}
else if (ChisloAmount == 3)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
Double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Итог: " + x * y);


}
else if (ChisloAmount == 4)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
Double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Итог: " + x / y);


}
else if (ChisloAmount == 5)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень, в которую хотите возвести число : ");
Double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Итог: " + Math.Pow(x, y));


}
else if (ChisloAmount == 6)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Итог: " + Math.Sqrt(x));


}
else if (ChisloAmount == 7)
{
Console.WriteLine("Введите первое число: ");
Double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Итог 1% = " + x / 100);

}
else if (ChisloAmount == 8)
{
Console.WriteLine("Введите число, которое хотите возвести в факториал: ");
int x = Convert.ToInt32(Console.ReadLine());
int f = 1;
for (int i = 1; x >= i; ++i)
{
f = f * i;
}
Console.WriteLine(f);
}
else if (ChisloAmount == 9)
{
Console.WriteLine("Программа завершена");
break;
}
Console.WriteLine("Хотите продолжить? (yes/no)");
Povtor = Convert.ToString(Console.ReadLine());
} while (Povtor == "yes");

