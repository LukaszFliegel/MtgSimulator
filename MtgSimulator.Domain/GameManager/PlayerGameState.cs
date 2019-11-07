using MtgSimulator.Cards;
using MtgSimulator.Domain.Zones;

namespace MtgSimulator.Domain.GameManager
{
    public class PlayerGameState
    {
        private const int numberOfStartingCards = 7;

        private readonly string _deckCsvFilePath;
        private readonly ICardFactory _cardFactory;

        public HandZone HandZone { get; private set; }
        public GraveyardZone _graveyardZone { get; private set; }

        public Deck Deck { get; private set; }

        public int TurnCounter { get; private set; }

        public PlayerGameState(string deckCsvFilePath, ICardFactory cardFactory)
        {
            _deckCsvFilePath = deckCsvFilePath;
            _cardFactory = cardFactory;

            HandZone = new HandZone();
            _graveyardZone = new GraveyardZone();
            
        }

        public void InitializeGameState()
        {
            Deck = new Deck(_cardFactory);
            Deck.LoadFromCsv(_deckCsvFilePath);
            Deck.Shuffle();

            HandZone.ClearHand();
            _graveyardZone.ClearGraveyard();

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
    }
}
