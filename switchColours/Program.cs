do
{
    Console.Write("Введите название Вашего любимого цвета на английском языке и с маленькой буквы: ");
    string userColor = Console.ReadLine();
    switch (userColor)
    {
        case "red":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Ваш любимый цвет - {userColor}!");
            break;
        case "green":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Ваш любимый цвет - {userColor}!");
            break;
        case "cyan":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Ваш любимый цвет - {userColor}!");
            break;
        default:
            userColor = "yellow";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ваш любимый цвет - {userColor}!))");
            break;
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Чтобы выбрать иной цвет - нажмите Enter, чтобы прервать программу - Escape . . .");
} while (Console.ReadKey().Key != ConsoleKey.Escape);
