using System;
public static class Program
{
    public static int PlayerScore = 0;
    public static int RivalScore = 0;
    public static void Main()
    {
        Console.Clear();
        /*Intro*/ Console.WriteLine("Dice Game \n \nIn this game you and a computer Rival will play 10 rounds \nwhere you will each roll a 6-sided dice, and the player \nwith the highest dice value will win the round. The player \nwho wins the most rounds wins the game. Good luck! \n");
        Console.WriteLine("Press any key to start...");
        Console.ReadLine();
        for (int round = 1; round < 11; round++) 
        {
            GameLoop(round);
        }
        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You : {PlayerScore}. Rival : {RivalScore}. ");
        if (PlayerScore > RivalScore) {Console.WriteLine("You won!");}
        else if (PlayerScore < RivalScore) {Console.WriteLine("You lost!");}
        else if (PlayerScore == RivalScore) {Console.WriteLine("The game is a draw.");}
        Console.WriteLine("Press any key to exit...");
        Console.Read();
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
        Environment.Exit(0);
    }

    public static void GameLoop(int round)
    {
        Random rnd = new Random();
        int RivalRoll = rnd.Next(1, 7);
        int PlayerRoll = rnd.Next(1, 7);
        Console.WriteLine($"Round {round}");
        Console.WriteLine($"Rival rolled a {RivalRoll}");
        Console.Write("Press any key to roll the dice...   ");
        Console.Read();
        Console.WriteLine($"You rolled a {PlayerRoll}");
        if (PlayerRoll > RivalRoll) {Console.WriteLine("You won this round."); PlayerScore++;}
        else if (PlayerRoll < RivalRoll) {Console.WriteLine("The Rival won this round. "); RivalScore++;}
        else if (PlayerRoll == RivalRoll) {Console.WriteLine("This round is a draw!");}
        Console.WriteLine($"The score is now - You : {PlayerScore}. Rival : {RivalScore}. ");
        Console.WriteLine("Press any key to continue...    ");
        Console.Read();
    }
}