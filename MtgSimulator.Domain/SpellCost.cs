using System.Collections.Generic;

namespace MtgSimulator.Domain
{
    public class SpellCost
    {
        public int ColorlessManaAmount { get; }

        public IList<ManaSymbol> ColorManaSymbols { get; }
        public bool UsesVariantAmount { get; }
        public int MinimumValueForVariantMana { get; }

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
        public SpellCost(bool usesVariantAmount, int minimumValueForVariantMana, IList<ManaSymbol> colorManaSymbols)
        {
            UsesVariantAmount = usesVariantAmount;
            MinimumValueForVariantMana = minimumValueForVariantMana;
            ColorlessManaAmount = 0;
            ColorManaSymbols = colorManaSymbols;
        }
    }
}
