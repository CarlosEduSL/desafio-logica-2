using System;
using System.Net;
using System.Runtime.CompilerServices;

class RankedCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of wins:");
        int wins = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of losses:");
        int losses = int.Parse(Console.ReadLine());

        int balance = Calculatedbalance(wins, losses);
        string level = DetermineLevel(wins);

        Console.WriteLine($"The Hero has a balance of {balance} and is at the level {level}." );
    }

    static int Calculatedbalance(int wins, int losses)
    {
        return wins - losses;
    }

    static string DetermineLevel(int wins)
    {
        switch (wins)
        {
            case < 10:
                return "Iron";

            case <= 20:
                return "Bronze";

            case <= 50:
                return "Silver";
            
            case <= 80:
                return "Gold";
            
            case <= 90:
                return "Diamond";

            case <= 100:
                return "Immortal";
            
            default:
                return "Radiant";
        }
    }

}