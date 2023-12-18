// See https://aka.ms/new-console-template for more information

using bowlingTDD;

Console.WriteLine("Hello, Bowling game starts!");
var game = new Game();
game.Roll(10); // strike! score of frame 1 = 10+3+2 =15
game.Roll(2); 
game.Roll(3);
game.RollMany(16,0);

Console.WriteLine("Score: "+ game.Score());
