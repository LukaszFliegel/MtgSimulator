using System.Collections.Generic;
using System.Linq;

namespace MtgSimulator.Domain
{
    public class AvailableMana
    {
        public int TotalAmountOfMana { get; set; }
        public int TotalManaSpent { get; set; }

        public int AvailableTotalAmountOfMana => TotalAmountOfMana - TotalManaSpent;

        // If we have Mountain + Overgrown Tomb + Breeding Pool then this list of list will contain:
        // R + B + U
        // R + B + G
        // R + G + U
        // R + G + G
        public IList<IList<ManaSymbol>> EveryManaSymbolCombination { get; set; }

        public IEnumerable<IList<ManaSymbol>> AvailableManaSymbolsCombinations { get
            {
                foreach (var manaSymbolsCombination in EveryManaSymbolCombination)
                {
                    if (!SpentManaSymbols.SequenceEqual(manaSymbolsCombination))
                        yield return manaSymbolsCombination;
                }
            }
        }

        public IList<ManaSymbol> SpentManaSymbols { get; set; }

        public AvailableMana()
        {
            EveryManaSymbolCombination = new List<IList<ManaSymbol>>();
            SpentManaSymbols = new List<ManaSymbol>();
        }

        public override string ToString()
        {
            if (EveryManaSymbolCombination.Any())
            {
                string W = string.Empty;
                for (int i = 0; i < EveryManaSymbolCombination.Max(p => p.Count(q => q == ManaSymbol.White)); i++)
                {
                    W += "W";
                }

                string U = string.Empty;
                for (int i = 0; i < EveryManaSymbolCombination.Max(p => p.Count(q => q == ManaSymbol.Blue)); i++)
                {
                    U += "U";
                }

                string B = string.Empty;
                for (int i = 0; i < EveryManaSymbolCombination.Max(p => p.Count(q => q == ManaSymbol.Black)); i++)
                {
                    B += "B";
                }

                string R = string.Empty;
                for (int i = 0; i < EveryManaSymbolCombination.Max(p => p.Count(q => q == ManaSymbol.Red)); i++)
                {
                    R += "R";
                }

                string G = string.Empty;
                for (int i = 0; i < EveryManaSymbolCombination.Max(p => p.Count(q => q == ManaSymbol.Green)); i++)
                {
                    G += "G";
                }

                return $"{TotalAmountOfMana}, with max: {W}, {U}, {B}, {R}, {G}";
            }
            else
            {
                return $"{TotalAmountOfMana} available mana";
            }
        }
    }
}