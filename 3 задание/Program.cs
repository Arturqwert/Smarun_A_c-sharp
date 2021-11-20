int check(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Некорректный ввод");
        return (0);
    }
    return (1);
}

void outputarray(int[] numbers)
{
    Console.WriteLine();
    Console.WriteLine("Введённый массив:");
    Console.WriteLine();
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void outputarray3(int[] numbers)
{
    Console.WriteLine();
    Console.WriteLine("Элементы массива, кратные 3:");
    Console.WriteLine();
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 3 == 0 && numbers[i] != 0)
            Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine("Задание 3: \nСоставить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3\n");
while (true)
{
    Console.WriteLine("Введите размер числового массива. Для выхода введите \"exit\"");
    string? input1 = Console.ReadLine();
    bool a = int.TryParse(input1, out int number);

    switch (a)
    {
        case true:
            {
                if (check(number) == 1)
                {
                    int[] numbers = new int[number];
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine($"Введите {i + 1} элемент массива.  Для выхода введите \"exit\"");
                        string? input2 = Console.ReadLine();
                        bool a2 = int.TryParse(input2, out int number2);
                        if (a2)
                            numbers[i] = number2;
                        else if (input2 == "exit")
                            return;
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                            i--;
                        }
                    }
                    outputarray(numbers);
                    outputarray3(numbers);
                }
            }
            break;
        case false:
            {
                if (input1 != "exit")
                    Console.WriteLine("Некорректный ввод");
            }
            break;
    }
    if (input1 == "exit")
        break;
}
