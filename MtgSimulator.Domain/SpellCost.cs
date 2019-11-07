using System.Collections.Generic;

namespace MtgSimulator.Domain
{
    public class SpellCost
    {
        public int ColorlessManaAmount { get; set; }

        public IList<ManaSymbol> ColorManaSymbols { get; set; }
        public bool UsesVariantAmount { get; }

        public SpellCost(int colorlessManaAmount, IList<ManaSymbol> colorManaSymbols)
        {
            UsesVariantAmount = false;
            ColorlessManaAmount = colorlessManaAmount;
            ColorManaSymbols = colorManaSymbols;
        }

        public SpellCost(IList<ManaSymbol> colorManaSymbols)
        {
            UsesVariantAmount = false;
            ColorlessManaAmount = 0;
            ColorManaSymbols = colorManaSymbols;
        }

        // TTA: how to represent variable amount of colorless mana?
        public SpellCost(bool usesVariantAmount, IList<ManaSymbol> colorManaSymbols)
        {
            UsesVariantAmount = usesVariantAmount;
            ColorlessManaAmount = 0;
            ColorManaSymbols = colorManaSymbols;
        }
    }
}
