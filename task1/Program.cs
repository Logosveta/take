int Number1 = new int();
Console.WriteLine("Введите первое число:");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите второе число:");
Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 < Number2)
{
    Console.Write("Большее число:");
    Console.WriteLine(Number2);
}
else
{
    Console.Write("Большее число:");
    Console.WriteLine(Number1);
}