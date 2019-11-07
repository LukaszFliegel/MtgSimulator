using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using System;
using System.Collections.Generic;

namespace MtgSimulator.Cards.Creatures
{
    public class GildedGooseCard : Creature
    {
        public GildedGooseCard()
            : base("Gilded Goose", power: 0, toughtness: 2, ManaSymbol.Green)
        {
        }
    }
}
