using FluentAssertions;
using MtgSimulator.Cards;
using MtgSimulator.Cards.Creatures;
using MtgSimulator.Domain.Cards;
using NUnit.Framework;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Tests
{
    public class CastableSpellsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //private (int, ManaSymbol[]) _sourceLists = (4, { ManaSymbol.Green, ManaSymbol.Green, ManaSymbol.Blue, ManaSymbol.Blue });

        [TestCase("Wicked Wolf", 4, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 4, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 6, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 100, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 10, ManaSymbol.Green, ManaSymbol.Green, ManaSymbol.Blue, ManaSymbol.Blue, ManaSymbol.Red, ManaSymbol.Red, ManaSymbol.Black, ManaSymbol.Black, ManaSymbol.White, ManaSymbol.White)]

        [TestCase("Paradise Druid", 2, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 4, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 12, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 4, ManaSymbol.White, ManaSymbol.Blue, ManaSymbol.Black, ManaSymbol.Red, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 2, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 4, ManaSymbol.Green, ManaSymbol.Green, ManaSymbol.Green, ManaSymbol.Red)]
        public void CreatureIsCastable(string spellCardName, int totalAmountOfMana, params ManaSymbol[] manaSymbols)
        {
            // arrange
            var cardFactory = new CardFactory();
            var card = cardFactory.InstantiateSpell(spellCardName);
            var availableMana = new AvailableMana();

            availableMana.TotalAmountOfMana = totalAmountOfMana;
            availableMana.AvailableManaSymbols.Add(manaSymbols);

            // act & assert            
            card.IsCastable(availableMana).Should().BeTrue();
        }

        [TestCase("Wicked Wolf", 2, ManaSymbol.Black, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 2, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 3, ManaSymbol.Green, ManaSymbol.Green)]
        [TestCase("Wicked Wolf", 4, ManaSymbol.Blue, ManaSymbol.Blue)]
        [TestCase("Wicked Wolf", 8, ManaSymbol.Blue, ManaSymbol.Blue, ManaSymbol.Red, ManaSymbol.Red, ManaSymbol.Black, ManaSymbol.Black, ManaSymbol.White, ManaSymbol.White)] 
        [TestCase("Wicked Wolf", 100, ManaSymbol.White, ManaSymbol.White, ManaSymbol.White, ManaSymbol.White)]

        [TestCase("Paradise Druid", 2, ManaSymbol.White)]
        [TestCase("Paradise Druid", 2, ManaSymbol.Blue)]
        [TestCase("Paradise Druid", 2, ManaSymbol.Black)]
        [TestCase("Paradise Druid", 2, ManaSymbol.Red)]
        [TestCase("Paradise Druid", 1, ManaSymbol.Green)]
        [TestCase("Paradise Druid", 4, ManaSymbol.White, ManaSymbol.Blue, ManaSymbol.Black, ManaSymbol.Red)]

        public void CreatureIsNotCastable(string spellCardName, int totalAmountOfMana, params ManaSymbol[] manaSymbols)
        {
            // arrange
            var cardFactory = new CardFactory();
            var card = cardFactory.InstantiateSpell(spellCardName);
            var availableMana = new AvailableMana();

            availableMana.TotalAmountOfMana = totalAmountOfMana;
            availableMana.AvailableManaSymbols.Add(manaSymbols);

            // act & assert
            card.IsCastable(availableMana).Should().BeFalse();
        }
    }
}