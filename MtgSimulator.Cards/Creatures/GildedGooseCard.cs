using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;
using System;
using System.Collections.Generic;

namespace MtgSimulator.Cards.Creatures
{
    public class GildedGooseCard : Creature
    {
        public GildedGooseCard(PlayerGameState playerGameState)
            : base("Gilded Goose", playerGameState, power: 0, toughtness: 2, ManaSymbol.Green)
        {
        }
    }
}
