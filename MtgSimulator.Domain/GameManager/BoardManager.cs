using MtgSimulator.Cards;

namespace MtgSimulator.Domain.GameManager
{
    public class BoardManager
    {
        public PlayerGameState PlayerGameState;

        public BoardManager(string deckCsvFilePath, ICardFactory cardFactory)
        {
            PlayerGameState = new PlayerGameState(deckCsvFilePath, cardFactory);
        }

        public void InitializeBoardManager()
        {
            PlayerGameState.InitializeGameState();
        }
    }
}
