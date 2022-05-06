
using PigDice;

var piggie = new PigDiceGame();

var highscore = 1000;
long games = 0;
var highest = 0;
var score = piggie.Play();

while (score < highscore) {
    score = piggie.Play();
    games++;
    if (score > highest) {
        highest = score;
    }
    if (games % 100000000 == 0) {
        Console.WriteLine($"{games:n0} games played. High score: {highest}");
    }
}

