using MtgSimulator.Cards.Creatures;
using MtgSimulator.Cards.Instants;
using MtgSimulator.Cards.Lands;
using MtgSimulator.Cards.Planeswalkers;
using MtgSimulator.Cards.Sorceries;
using MtgSimulator.Domain.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Cards
{
    public class CardFactory : ICardFactory
    {
        public Card InstantiateCard(string name)
        {
            return (Card)Activator.CreateInstance(CardNamesMap[name]);
        }

        private Dictionary<string, Type> CardNamesMap = new Dictionary<string, Type>()
        {
            { "Gilded Goose", typeof(GildedGooseCard) },
            { "Hydroid Krasis", typeof(HydroidKrasisCard) },
            { "Massacre Girl", typeof(MassacreGirlCard) },
            { "Paradise Druid", typeof(ParadiseDruidCard) },
            { "Wicked Wolf", typeof(WickedWolfCard) },
            { "Liliana, Dreadhorde General", typeof(LilianaDreadhordeGeneralCard) },
            { "Nissa, Who Shakes the World", typeof(NissaWhoShakesTheWorldCard) },
            { "Oko, Thief of Crowns", typeof(OkoThiefOfCrownsCard) },
            { "Vraska, Golgari Queen", typeof(VraskaGolgariQueenCard) },
            { "Legion's End", typeof(LegionsEndCard) },
            { "Noxious Grasp", typeof(NoxiousGraspCard) },
            { "Once Upon a Time", typeof(OnceUponATimeCard) },
            { "Breeding Pool", typeof(BreedingPoolCard) },
            { "Fabled Passage", typeof(FabledPassageCard) },
            { "Forest", typeof(ForestCard) },
            { "Island", typeof(IslandCard) },
            { "Overgrown Tomb", typeof(OvergrownTombCard) },
            { "Swamp", typeof(SwampCard) },
            { "Temple of Malady", typeof(TempleOfMaladyCard) },
            { "Watery Grave", typeof(WateryGraveCard) },

        };
    }
}
