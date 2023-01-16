// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int new_N = (N / 100) * 10 + N%10;
Console.WriteLine(new_N);