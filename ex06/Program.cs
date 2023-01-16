// Показать вторую цифру трехзначного числа
Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра: " + ((N%100 - N%10) / 10));
