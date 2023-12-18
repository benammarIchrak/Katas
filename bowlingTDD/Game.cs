namespace bowlingTDD;

public class Game
{
    public int score;
    public  int[] rolls = new int [21];
    private int currentRoll = 0;

    public void Roll(int nbPins)
    {
        rolls[currentRoll] = nbPins;
        currentRoll++;
    }
    public void RollMany(int nbrolls, int nbPins)
    {
        for (int i = 0; i < nbrolls; i++)
        {
            Roll(nbPins);
        }
    }
    public int Score()
    {
        int roll = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (rolls[roll] == 10)
            {
                score += rolls[roll] + rolls[roll + 1] + rolls[roll + 2];
                roll ++;
            }

            if (rolls[roll] + rolls[roll + 1] == 10)
            {
                score += rolls[roll] + rolls[roll + 1] + rolls[roll + 2];
                roll+= 2;

            }
            else
            {
                score += rolls[roll] + rolls[roll+1];
                roll+= 2;
            }
        }

        return score;
    }
}