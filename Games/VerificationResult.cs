namespace Games;

public class VerificationResult
{
    internal string DataVerification()
    {
        
        var playerData = new Player();
        var playerName = playerData.Name();
        var userNumber = playerData.UserNumberEntry();
        var number = new DataGeneration();
        var numberGenerator = number.GaneratorNuber();

        var count = 0;
        while (true)
        {
            if (userNumber < numberGenerator)
            {
                Console.WriteLine(
                    $"{playerName}, твоё число {userNumber} и оно меньше, чем задумал компьютер. Пробуй ещё раз.");
                Console.Write($"{playerName}, введи новое число : ");
                userNumber = int.Parse(Console.ReadLine());
                count++;
            }
            else if (userNumber > numberGenerator)
            {
                Console.WriteLine(
                    $"{playerName}, твоё число {userNumber} и оно больше, чем задумал компьютер. Пробуй ещё раз.");
                Console.Write($"{playerName}, введи новое число : ");
                userNumber = int.Parse(Console.ReadLine());
                count++;
            }
            else
            {
                Console.WriteLine(
                    $"Поздравляю, {playerName}! Ты угадал(а) {numberGenerator} и тебе понадобилось {count} попыток! ");
                break;
            }
        }

        return null;
    }
}