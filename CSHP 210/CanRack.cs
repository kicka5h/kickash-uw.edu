// Karczag, Ash
// kickash@uw.edu

using System;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Ex_5._3_CoinBox
{
    public class CanRack
    {
        Dictionary<Flavor, int> rack = null;

        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        // Constructor for a can rack. The rack starts out full
        public CanRack()
        {
            rack = new Dictionary<Flavor, int>();
            FillTheCanRack();
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {

            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine($"Sorry, {FlavorOfCanToBeAdded} could not be added to the rack because the rack is already full.");
            }
            else
            {
                Debug.WriteLine($"Adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack.");
                Flavor flavorInt = FlavorOps.toFlavorString(FlavorOfCanToBeAdded);
                rack[flavorInt]++;
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {

            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Sorry, {FlavorOfCanToBeRemoved} could not be removed from the rack because the rack is empty.");
            }
            else
            {
                Debug.WriteLine($"Removing a can of {FlavorOfCanToBeRemoved} from the rack.");
                Flavor flavorInt = FlavorOps.toFlavorString(FlavorOfCanToBeRemoved);
                rack[flavorInt]--;
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This method will fill the can rack
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack...");

            foreach (Flavor oneFlavor in FlavorOps.TheFlavors)
            {
                rack[oneFlavor] = BINSIZE;
            }

        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();

            Debug.WriteLine($"Emptying can rack of flavor {FlavorOfBinToBeEmptied}");

            Flavor emptyFlavor = FlavorOps.toFlavorString(FlavorOfBinToBeEmptied);
            rack[emptyFlavor] = EMPTYBIN;
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Boolean result = false;
            Debug.WriteLine($"Checking if can rack is full of flavor {FlavorOfBinToBeChecked}");

            Flavor flavorEnumeral = FlavorOps.toFlavorString(FlavorOfBinToBeChecked);
            result = rack[flavorEnumeral] == BINSIZE;
            return result;
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            bool result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked);

            Flavor flavorEnumeral = FlavorOps.toFlavorString(FlavorOfBinToBeChecked);
            result = rack[flavorEnumeral] == EMPTYBIN;
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }

    } //end Can_Rack
}
