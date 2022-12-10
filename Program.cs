Console.WriteLine("Введите число 1");
string number0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string number1 = Console.ReadLine();
Console.WriteLine("Введите число 3");
string number2 = Console.ReadLine();
int num0 = Convert.ToInt32(number0);
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);

if (num0 > num1 && num0 > num2)
{
    Console.WriteLine($"max = {num0}");
}
if (num1 > num0 && num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
if (num2 > num0 && num2 > num1)
{
    Console.WriteLine($"max = {num2}");
}
