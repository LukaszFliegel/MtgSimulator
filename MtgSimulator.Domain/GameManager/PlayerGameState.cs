using MtgSimulator.Cards;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.Zones;
using System.Collections.Generic;
using System.Linq;

namespace MtgSimulator.Domain.GameManager
{
    public class PlayerGameState
    {
        private const int numberOfStartingCards = 7;

        private readonly ICardFactory _cardFactory;

        public HandZone HandZone { get; private set; }
        public GraveyardZone GraveyardZone { get; private set; }

        public BattlefieldZone BattlefieldZone { get; private set; }

        public Deck Deck { get; private set; }

        public int TurnCounter { get; private set; }

        public PlayerGameState(ICardFactory cardFactory)
        {
            _cardFactory = cardFactory;

            HandZone = new HandZone();
            GraveyardZone = new GraveyardZone();
            BattlefieldZone = new BattlefieldZone();
        }

        public void InitializeGameState(string deckCsvFilePath)
        {
            Deck = new Deck(_cardFactory);
            Deck.LoadFromCsv(deckCsvFilePath, this);
            Deck.Shuffle();

            HandZone.ClearHand();
            GraveyardZone.ClearGraveyard();
            BattlefieldZone.ClearBattlefield();

            TurnCounter = 1;

            DrawOpeningHand();
        }

        public void InitializeGameState(IEnumerable<string> deckCardNames)
        {
            Deck = new Deck(_cardFactory);
            Deck.LoadCardByNames(deckCardNames, this);
            Deck.Shuffle();

            HandZone.ClearHand();
            GraveyardZone.ClearGraveyard();
            BattlefieldZone.ClearBattlefield();

            TurnCounter = 1;

            DrawOpeningHand();
        }

        public void DrawCardFromDeck()
        {
            var drawnCard = Deck.DrawCard();
            drawnCard.OnDraw();
            HandZone.AddCardToHand(drawnCard);
        }

        public void DrawOpeningHand()
        {
            for (int i = 0; i < numberOfStartingCards; i++)
            {
                DrawCardFromDeck();
            }
        }

        public AvailableMana AvailableMana()
        {
            var avilableMana = new AvailableMana();

            var landsCapableOfProducingMana = BattlefieldZone.Cards.Where(card => card is Land).Select(card => card as Land).Where(land => !land.Tapped).ToArray();

            foreach (var land in landsCapableOfProducingMana)
            {
                // assuming every land can produce only one mana
                avilableMana.TotalAmountOfMana++;                
            }

            var numberOfCombination = landsCapableOfProducingMana.SelectMany(p => p.GeneratesManaSymbols()).Count();
            var manaCombinationIndex = new int[landsCapableOfProducingMana.Length];
            for (int i = 0; i < manaCombinationIndex.Length; i++)
            {
                manaCombinationIndex[i] = 0;
            }

            // calculate every combination of available mana
            for (int k = 0; k < numberOfCombination; k++)
            {
                
                // TODO: 
                for (int i = 0; i < landsCapableOfProducingMana.Length; i++)
                {
                    if (i > 0) manaCombinationIndex[i - 1] = 0;

                    var availableManaSymbolsCombination = new List<ManaSymbol>();

                    for (int j = 0; j < landsCapableOfProducingMana[i].GeneratesManaSymbols().Length; j++)
                    {
                        manaCombinationIndex[i] = j;
                        availableManaSymbolsCombination.Add(landsCapableOfProducingMana[i].GeneratesManaSymbols()[j]);
                    }
                }
            }

            //foreach (var land in landsCapableOfProducingMana)
            //{
            //    foreach (var manaSymbol in land.GeneratesManaSymbols())
            //    {

            //    }
            //}

            return avilableMana;
        }
    }
}
