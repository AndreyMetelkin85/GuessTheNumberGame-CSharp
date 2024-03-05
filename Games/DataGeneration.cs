namespace Games;

public class DataGeneration
{
    internal int GaneratorNuber()
    {
        var rand = new Random();
        var random = rand.Next(100);
        
        return random;
    }
}