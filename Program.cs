using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string userInput = Console.ReadLine();
            double userNum = Convert.ToDouble(userInput);
            Console.WriteLine($"{userNum} is equal to...");
            int goldCoin = 10;
            int silverCoin = 5;
            double goldCoins = Math.Floor(userNum / goldCoin);
            double remainder = userNum % goldCoin;
            double silverCoins = Math.Floor(remainder / silverCoin);
            remainder = remainder % silverCoin;
            Console.WriteLine($"Gold Coins : {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {remainder}");
            double totalCoins = goldCoins + silverCoins + remainder;
            Console.WriteLine($"Total coins = {totalCoins}");
        }
    }
}
