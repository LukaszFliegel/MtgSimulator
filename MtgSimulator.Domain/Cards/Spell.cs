using MtgSimulator.Domain.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Spell : Card
    {
        private SpellCost Cost { get; set; }

        protected Spell(string name, int usesVariantAmountCost, IList<ManaSymbol> colorManaSymbols) : base(name)
        {
            Cost = new SpellCost(usesVariantAmountCost, colorManaSymbols);
        }

        protected Spell(string name, bool usesVariantAmountCost, IList<ManaSymbol> colorManaSymbols) : base(name)
        {
            Cost = new SpellCost(usesVariantAmountCost, colorManaSymbols);
        }

        public override int Cmc()
        {
            return Cost.ColorlessManaAmount + Cost.ColorManaSymbols.Count;
        }

        public override IEnumerable<ManaSymbol> Colors()
        {
            if (Cost.ColorManaSymbols.Count == 0)
            {
                yield return ManaSymbol.Colorless;
            }
            else
            {
                foreach (var color in Cost.ColorManaSymbols)
                {
                    yield return color;
                }
            }
        }

        public override void PlayCard()
        {
            CardZone = CardZone.Stack;
        }

        public bool IsCastable(AvailableMana availableMana)
        {
            if(Cmc() <= availableMana.TotalAmountOfMana)
            {
                if (availableMana.AvailableManaSymbols.Any(manaCombination => manaCombination.ContainsAll(Cost.ColorManaSymbols)))
                    return true;
            }

            return false;
        }
    }
}
