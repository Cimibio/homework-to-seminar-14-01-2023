Console.Write("Введите число для проверки четности: ");
int n = int.Parse(Console.ReadLine());
if (n%2 == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");