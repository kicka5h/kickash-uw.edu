// Karczag, Ash
// kickash@uw.edu

using System;
using System.Collections.Generic;

namespace Ex_5._3_CoinBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.25M);
            CanRack sodaRack = new CanRack();
            DisplayRack showFlavors = new DisplayRack();
            CoinBox depositCoin = new CoinBox(new List<Coin> { 
                new Coin(Coin.Coins.HALFDOLLAR), new Coin(Coin.Coins.QUARTER), 
                new Coin(Coin.Coins.DIME), new Coin(Coin.Coins.NICKEL),
                new Coin(Coin.Coins.PENNY), new Coin(Coin.Coins.COIN) }); 

            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("========Welcome to the C# Vending Machine======");
            Console.WriteLine("===============================================");
            Console.WriteLine("==========Today's Soda Price is $.025==========");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.WriteLine(" ____________________________________________ :");
            Console.WriteLine("|############################################|:");
            Console.WriteLine("|#|                           |##############|:");
            Console.WriteLine("|#|  =====  ..--''`  |~~``|   |##|````````|##|:");
            Console.WriteLine("|#|  |   |   |    |  :    |   |##| Exact  |##|:");
            Console.WriteLine("|#|  |___|   | ___|  | ___|   |##| Change |##|:");
            Console.WriteLine("|#|  |   |   |    |  |  __|   |##| Only   |##|:");
            Console.WriteLine("|#|  |   |   |__  |  :__  |   |##|________|##|:");
            Console.WriteLine("|#|===========================|##############|:");
            Console.WriteLine("|#|```````````````````````````|##############|:");
            Console.WriteLine("|#|  =.._       ++    //////  |##############|:");
            Console.WriteLine("|#|  |/   |    | |   |     |  |#|`````````|##|:");
            Console.WriteLine("|#|  |___ |    |_|   |___  |  |#| _______ |##|:");
            Console.WriteLine("|#|  | __ |    |_|   | __  |  |#| |1|2|3| |##|:");
            Console.WriteLine("|#|  |__//-    |_|   |__   |  |#| |4|5|6| |##|:");
            Console.WriteLine("|#|===========================|#| |7|8|9| |##|:");
            Console.WriteLine("|#|```````````````````````````|#| ``````` |##|:");
            Console.WriteLine("|#|  ..--    ______   .--._.  |#|[=======]|##|:");
            Console.WriteLine("|#|  |   |   |    |   |    |  |#|  _   _  |##|:");
            Console.WriteLine("|#|  |___|   : ___:   | ___|  |#| ||| ( ) |##|:");
            Console.WriteLine("|#|  / __|   | __ |   | __ |  |#| |||  `  |##|:");
            Console.WriteLine("|#|  |__ |   |__  |   |__  |  |#|  ~      |##|:");
            Console.WriteLine("|#|===========================|#|_________|##|:");
            Console.WriteLine("|#|```````````````````````````|##############|:");
            Console.WriteLine("|############################################|:");
            Console.WriteLine("|#|||||||||||||||||||||||||||||####```````###|:");
            Console.WriteLine("|#||||||||||||PUSH|||||||||||||####|||||||###|:");
            Console.WriteLine("|############################################|:");
            Console.WriteLine("//////////////////////////////////////////////:");
            Console.WriteLine("|___________________________________|CR98|___|:");

            Boolean exitVend = false;
            do
            {
                decimal totalValueInserted = 0M;
                while (totalValueInserted < sodaPrice.PriceDecimal)
                {
                    bool checkValue = false;
                    if (totalValueInserted == sodaPrice.PriceDecimal)
                    {
                        checkValue = true;
                    }

                    if (checkValue == false)
                    {
                        Console.Write("Please insert coins one at a time: ");

                        string coinNameInserted = Console.ReadLine().ToUpper();
                        Coin coinInserted = new Coin(coinNameInserted);
                        depositCoin.Deposit(coinInserted);

                        Console.WriteLine("You have inserted a {0} worth {1:c}", coinInserted, coinInserted.ValueOf);

                        totalValueInserted += coinInserted.ValueOf;
                        Console.WriteLine("Total value inserted is {0:c}", totalValueInserted);
                    }
                }

                Console.WriteLine("Thanks, you have now inserted {0:c}", totalValueInserted);
                Console.WriteLine($"Please choose your flavor: {showFlavors.DisplayCanRackString()}:");

                string choseFlavor = Console.ReadLine();
                string chosenFlavor = choseFlavor.ToUpper();

                string[] flavorChoice = Enum.GetNames(typeof(Flavor));
                bool isFlavorName = false;
                foreach (string flavorName in flavorChoice)
                {
                    if (flavorName.Equals(chosenFlavor)) isFlavorName = true;
                }

                if (isFlavorName == true)
                {
                    bool checkRack = sodaRack.IsEmpty(chosenFlavor);
                    if (checkRack == false)
                    {
                        sodaRack.RemoveACanOf(chosenFlavor);
                        Console.WriteLine($"Thanks, here is your {chosenFlavor} soda.");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, there is no more {chosenFlavor} flavor soda.");
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry, {chosenFlavor} is not an available flavor.");
                }

                Console.WriteLine("Would you like to exit the vending machine? (y/n)");
                Console.WriteLine();

                string response = Console.ReadLine();

                if (response == "y")
                {
                    exitVend = true;
                }
            } while (exitVend == false);

            Console.WriteLine("The following coins are still in the coin box:");
            Console.WriteLine($"There are {depositCoin.HalfDollarCount} half dollars");
            Console.WriteLine($"There are {depositCoin.QuarterCount} quarters");
            Console.WriteLine($"There are {depositCoin.DimeCount} dimes");
            Console.WriteLine($"There are {depositCoin.NickelCount} nickels");
            Console.WriteLine($"There are {depositCoin.PennyCount} pennies");
            Console.WriteLine($"There are {depositCoin.CoinCount} unknown coins");
            Console.WriteLine($"The total value of coins in the coin box is {depositCoin.ValueOf}");
        }
    }
}
