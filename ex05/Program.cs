// Показать последнюю цифру трёхзначного числа
Console.Write("Введите треъзначное число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра: " + N%10);
