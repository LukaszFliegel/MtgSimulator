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

        private AvailableMana _availableMana = new AvailableMana();

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
            //Deck.Shuffle();

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

        public AvailableMana AvailableMana { 
            get
            {
                _availableMana.TotalAmountOfMana = 0;
                _availableMana.EveryManaSymbolCombination.Clear();

                var landsCapableOfProducingMana = BattlefieldZone.Cards
                    .Where(card => card is Land)
                    .Select(card => card as Land)
                    .Where(land => !land.Tapped)
                    .ToArray();

                foreach (var land in landsCapableOfProducingMana)
                {
                    // assuming every land can produce only one mana
                    _availableMana.TotalAmountOfMana++;
                }

                var numberOfCombination = landsCapableOfProducingMana.SelectMany(p => p.GeneratesManaSymbols()).Count();
                var manaCombinationIndex = new int[landsCapableOfProducingMana.Length];

                ResetTheIdexes(manaCombinationIndex);
               
                for (int i = 0; i < landsCapableOfProducingMana.Length; i++)
                {
                    if (i > 0) manaCombinationIndex[i - 1] = 0;

                    for (int j = 0; j < landsCapableOfProducingMana[i].GeneratesManaSymbols().Length; j++)
                    {
                        var availableManaSymbolsCombination = new List<ManaSymbol>();

                        AddManaSymbolCombinationForFollowingLands(landsCapableOfProducingMana, manaCombinationIndex, i, j, availableManaSymbolsCombination);

                        _availableMana.EveryManaSymbolCombination.Add(availableManaSymbolsCombination);
                        availableManaSymbolsCombination.Clear();
                        ResetTheIdexes(manaCombinationIndex);
                        //manaCombinationIndex[i] = j;
                    }
                }
                return _availableMana;
            }
        }

        private void AddManaSymbolCombinationForFollowingLands(Land[] landsCapableOfProducingMana, int[] manaCombinationIndex, int startFromLandIndex, int startFromLandManaSymbolIndex, List<ManaSymbol> availableManaSymbolsCombination)
        {
            for (int k = startFromLandIndex; k < landsCapableOfProducingMana.Length; k++)
            {
                manaCombinationIndex[k] = startFromLandManaSymbolIndex;

                if (k != startFromLandIndex)
                {
                    for (int l = 0; l < landsCapableOfProducingMana[k].GeneratesManaSymbols().Length; l++)
                    {
                        //availableManaSymbolsCombination.Add(landsCapableOfProducingMana[k].GeneratesManaSymbols()[l]);
                        manaCombinationIndex[k] = l;

                        //AddManaCombination(landsCapableOfProducingMana, manaCombinationIndex, availableManaSymbolsCombination);

                        availableManaSymbolsCombination.Add(landsCapableOfProducingMana[k].GeneratesManaSymbols()[l]);
                    }
                }
                else
                {
                    //AddManaCombination(landsCapableOfProducingMana, manaCombinationIndex, availableManaSymbolsCombination);
                    availableManaSymbolsCombination.Add(landsCapableOfProducingMana[k].GeneratesManaSymbols()[startFromLandManaSymbolIndex]);
                }
            }
        }

        private static void AddManaCombination(Land[] landsCapableOfProducingMana, int[] manaCombinationIndex, List<ManaSymbol> availableManaSymbolsCombination)
        {
            for (int m = 0; m < manaCombinationIndex.Length; m++)
            {
                availableManaSymbolsCombination.Add(landsCapableOfProducingMana[m].GeneratesManaSymbols()[manaCombinationIndex[m]]);
            }
        }

        private static void ResetTheIdexes(int[] manaCombinationIndex)
        {
            for (int i = 0; i < manaCombinationIndex.Length; i++)
            {
                manaCombinationIndex[i] = 0;
            }
        }
    }
}
