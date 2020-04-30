// Karczag, Ash
// kickash@uw.edu

using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_5._3_CoinBox
{
    class CoinBox
    {
        private List<Coin> Box;

        // create an empty coin box
        public CoinBox()
        {
            Box = new List<Coin>();
        }

        // create a coinbox with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            Box = SeedMoney;
        }

        // put a coin in the coin box
        public void Deposit (Coin ACoin)
        {
            Box.Add(ACoin);
        }

        // take a coin out of the coin box
        public Boolean Withdraw (Coin.Coins ACoinType)
        {
            var aCoin =
                from firstCoin in Box
                where firstCoin.CoinEnum == ACoinType
                select firstCoin;

            Boolean result = false;
            if (aCoin.Count() > 0)
            {
                result = Box.Remove(aCoin.First());
            }

            return result;
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get
            {
                var halfDollar =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.HALFDOLLAR
                    select coin;

                return halfDollar.Count();
            }
        }

        // number of quarters in the coin box
        public int QuarterCount
        {
            get
            {
                var quarter =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.QUARTER
                    select coin;

                return quarter.Count();
            }
        }

        // number of dimes in the coin box
        public int DimeCount
        {
            get
            {
                var dime =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.DIME
                    select coin;

                return dime.Count();
            }
        }

        // number of nickles in the coin box
        public int NickelCount
        {
            get
            {
                var nickel =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.NICKEL
                    select coin;

                return nickel.Count();
            }
        }

        // number of pennies in the coin box
        public int PennyCount
        {
            get
            {
                var penny =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.PENNY
                    select coin;

                return penny.Count();
            }
        }

        // number of unknnown coins in the coin box
        public int CoinCount
        {
            get
            {
                var unknowncoin =
                    from coin in Box
                    where coin.CoinEnum == Coin.Coins.COIN
                    select coin;

                return unknowncoin.Count();
            }
        }

        // calculate the total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal result =
                    HalfDollarCount * (decimal)Coin.Coins.HALFDOLLAR / 100M +
                    QuarterCount * (decimal)Coin.Coins.QUARTER / 100M +
                    DimeCount * (decimal)Coin.Coins.DIME / 100M +
                    NickelCount * (decimal)Coin.Coins.NICKEL / 100M +
                    PennyCount * (decimal)Coin.Coins.PENNY / 100M +
                    CoinCount * (decimal)Coin.Coins.COIN / 100M;

                return result;
            }
        }
    }
}
