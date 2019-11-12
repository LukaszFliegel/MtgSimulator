using MtgSimulator.Domain.Extensions;
using MtgSimulator.Domain.GameManager;
using MtgSimulator.Domain.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Spell : Card
    {
        public SpellCost Cost { get; private set; }

        protected Spell(string name, PlayerGameState playerGameState, int usesVariantAmountCost, IList<ManaSymbol> colorManaSymbols) : base(name, playerGameState)
        {
            Cost = new SpellCost(usesVariantAmountCost, colorManaSymbols);
        }

        protected Spell(string name, PlayerGameState playerGameState, bool usesVariantAmountCost, int minimumValueForVariantMana, IList<ManaSymbol> colorManaSymbols) : base(name, playerGameState)
        {
            Cost = new SpellCost(usesVariantAmountCost, minimumValueForVariantMana, colorManaSymbols);
        }

        public override int Cmc
        {
            get { return Cost.ColorlessManaAmount + Cost.ColorManaSymbols.Count; }
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

        //public override void PlayCard()
        //{
        //    CardZone = CardZone.Stack;
        //}

        public bool IsCastable(AvailableMana availableMana)
        {
            if(Cmc <= availableMana.TotalAmountOfMana)
            {
                // check if mana symbols required to cast this spell plus mana symbols already spent are in eligible mana symbols combination (i.e. you can cast this spell after previously cast spells)
                var spentManaPlusCostOfThisSpell = Cost.ColorManaSymbols.Concat(availableMana.SpentManaSymbols);

                if (availableMana.AvailableManaSymbols.Any(manaCombination => manaCombination.ContainsAll(spentManaPlusCostOfThisSpell)))
                    return true;
            }

            return false;
        }

        public void Cast(AvailableMana availableMana)
        {
            if (!IsCastable(availableMana))
                throw new InvalidOperationException("Attept to cast non castable spell");

            if(Cost.UsesVariantAmount)
            {

            }
            else
            {
                // substract CMC from total amount of mana to indicate how much available mana left
                availableMana.TotalAmountOfMana -= Cmc;

                foreach (var colormanaSymbol in Cost.ColorManaSymbols)
                {
                    availableMana.SpentManaSymbols.Add(colormanaSymbol);
                }
                
                //// from each mana symbols combination substract clored symbols from spell cost
                //// i.e. if we have Overgrown Tomb + Watery Grave + Breeding Pool
                //// we are able to generate following mana symbol combinations:
                //// B + U + U
                //// B + U + G //
                //// B + B + U
                //// B + B + G
                //// G + U + U //
                //// G + U + G //
                //// G + B + U //
                //// G + B + G
                //// if we cast UG spell, then following combinations
                //foreach (var availableManaSymbolsCombination in availableMana.AvailableManaSymbols)
                //{
                //    foreach (var colorManaSymbolFromCost in Cost.ColorManaSymbols)
                //    {
                //        if (availableManaSymbolsCombination.Contains(colorManaSymbolFromCost))
                //        {
                //            availableManaSymbolsCombination.Remove(colorManaSymbolFromCost);
                //        }
                //    }

                //}

            }
        }
    }
}
