// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня в неделе");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Первый день недели - понедельник!");
}
else if (day == 2)
{
    Console.WriteLine("Второй день недели - вторник!");
}
else if (day == 3)
{
    Console.WriteLine("Третий день недели - среда!");
}
else if (day == 4)
{
    Console.WriteLine("Четвертый день недели - четверг!");
}
else if (day == 5)
{
    Console.WriteLine("Пятый день недели - пятница!");
}
else if (day == 6)
{
    Console.WriteLine("Шестой день недели - суббота!");
}
else if (day == 7)
{
    Console.WriteLine("Седьмой день недели - воскресенье!");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}