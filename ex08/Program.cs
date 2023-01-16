// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите второе число для проверки кратности: ");
int num2 = int.Parse(Console.ReadLine());
if (num % num2 == 0 )
{
    Console.WriteLine("Число " + num + " кратно числу " + num2);
}
else 
{
    Console.WriteLine("Число " + num + " НЕ кратно числу " + num2 + ". Остаток: " + num%num2);
}