namespace Games;

public class VerificationResult
{
    internal string DataVerification()
    {
        var playerData = new Player();
        var playerName = playerData.Name();
        var number = new DataGeneration();
        var numberGenerator = number.GaneratorNuber();

        var count = 0;
        while (true)
        {
            var userNumber = playerData.UserNumberEntry();
            count++;
            
            if (userNumber < 0 | userNumber > 99)
                Console.WriteLine($"{playerName}, вы ввели не кореткное число, число должно быть от 0 до 99.");

            else if (userNumber < numberGenerator)
            {
                Console.WriteLine(
                    $"{playerName}, твоё число {userNumber} и оно меньше, чем задумал компьютер. Пробуй ещё раз.");
            }
            else if (userNumber > numberGenerator)
            {
                Console.WriteLine(
                    $"{playerName}, твоё число {userNumber} и оно больше, чем задумал компьютер. Пробуй ещё раз.");
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