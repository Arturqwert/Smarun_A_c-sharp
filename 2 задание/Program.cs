Console.WriteLine("Задание 2. \nСоставить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести \"Нет такого имени\"");
string? name;
while (true)
{
    Console.WriteLine("Введите имя. (Для выхода введите \"exit\")");
    name = Console.ReadLine();
    name = name.ToLower();
    if (name == "вячеслав")
        Console.WriteLine("Привет, Вячеслав");
    else if (name == "exit")
        break;
    else
        Console.WriteLine("Нет такого имени");
}
//wtf
