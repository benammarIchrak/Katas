namespace bowlingTDD.Tests;

public class GameTest
{
    private Game game;
    public GameTest()
    {
        game = new Game();
    }
    [Fact]
    public void ScoreShouldReturn0WhenPlayerRollsNoPin()
    {
        RollMany(20, 0);
        
        Assert.Equal(0, game.Score());
    }

    [Fact]
    public void ScoreShouldReturn20WhenPlayerRollsOnePinInEveryRoll()
    {
        RollMany(20,1);
        
        Assert.Equal(20, game.Score());
    }

    [Fact]
    public void testStrike()
    {

        game.Roll(10); // strike! score of frame 1 = 10+3+2 =15
        game.Roll(2); 
        game.Roll(3);
        RollMany(16,0);
        
        Assert.Equal(20,game.Score());
    }
    
    [Fact]
    public void testSpare()
    {
        game.Roll(6);
        game.Roll(4); //spare: 6+4=10 => score of frame 1 = 10+8=18
        game.Roll(8);
        RollMany(16,0);

        Assert.Equal(26,game.Score());
    }

    [Fact]
    public void testLastFramewithstrike()
    {
        var game = new Game();
        RollMany(18,0);

        game.Roll(10);
        game.Roll(5);
        game.Roll(2);
        
        Assert.Equal(24,game.Score());
    }

    private void RollMany(int nbrolls, int nbPins)
    {
        for (int i = 0; i < nbrolls; i++)
        {
            game.Roll(nbPins);
        }
    }
    
}