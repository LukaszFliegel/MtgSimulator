using System.Collections.Generic;

namespace MtgSimulator.Domain
{
    public class AvailableMana
    {
        public int TotalAmountOfMana;

        // If we have Island + Overgrown Tomb + Breeding Pool then this list of list will contain:
        // U + B + U
        // U + B + G
        // U + G + U
        // U + G + G
        public IList<IList<ManaSymbol>> AvailableManaSymbols;

        public AvailableMana()
        {
            AvailableManaSymbols = new List<IList<ManaSymbol>>();
        }
    }
}