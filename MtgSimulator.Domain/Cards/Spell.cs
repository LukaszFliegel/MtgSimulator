using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Spell : Card
    {
        private SpellCost Cost { get; set; }

        protected Spell(string name, int colorlessManaAmount, IList<ManaSymbol> colorManaSymbols) : base(name)
        {
            Cost = new SpellCost(colorlessManaAmount, colorManaSymbols);
        }

        protected Spell(string name, bool usesVariantAmount, IList<ManaSymbol> colorManaSymbols) : base(name)
        {
            Cost = new SpellCost(usesVariantAmount, colorManaSymbols);
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
            throw new System.NotImplementedException();
        }
    }
}
