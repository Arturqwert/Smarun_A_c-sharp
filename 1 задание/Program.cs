Console.WriteLine("Задание 1.\nСоставить алгоритм: если введенное число больше 7, то вывести “Привет”\n");
string? ReadedString;
while (true)
{
    Console.WriteLine("Введите любое число. (для выхода введите \"exit\")");
    ReadedString = Console.ReadLine();
    if (double.TryParse(ReadedString, out double number))
    {
        if (number > 7)
        {
            Console.WriteLine("Привет");
        }
    }
    else if (ReadedString == "exit")
        break;
    else
        Console.WriteLine("Некорректный ввод, попробуйте снова!");
}