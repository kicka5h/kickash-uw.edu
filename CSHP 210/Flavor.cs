// Karczag, Ash
// kickash@uw.edu

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Ex_5._3_CoinBox
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _theFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnum = toFlavorString(flavorName);
                _theFlavors.Add(flavorEnum);
            }
        }

        public static Flavor toFlavorString(string FlavorString)
        {
            Flavor result = Flavor.REGULAR;

            if (Enum.IsDefined(typeof(Flavor), FlavorString))
            {
                result = (Flavor)Enum.Parse(typeof(Flavor), FlavorString);
            }
            else
            {
                Debug.WriteLine($"Error Occurred: An attempt to convert an unknown string {FlavorString} has failed.");
            }
            return result;
        }

        public static List<Flavor> TheFlavors
        {
            get
            {
                return _theFlavors;
            }
        }
    }
}
