namespace Games;

internal class Player
{
    public static string name;

    internal string Name()
    {
        Console.WriteLine("!!!Игра угадай число!!!");
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine($"Привет {name}, давай поиграем в игру 'Угадай число', где компьютер загадывает число, " +
                          $"а ты, его пытаешься отгадать.");

        return name;
    }

    internal int UserNumberEntry()
    {
        Console.Write($"{name} введи число которое загадал компьютер :");
        var playerResult = int.Parse(Console.ReadLine());


        return playerResult;
    }
}