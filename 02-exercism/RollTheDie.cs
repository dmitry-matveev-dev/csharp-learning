public class Player
{
    Random randomRoll = new Random();
    public int RollDie()
    {
        int sideRoll = randomRoll.Next(1, 19);
        return sideRoll;
    }

    public double GenerateSpellStrength()
    {
       return randomRoll.NextDouble();
    }
}
