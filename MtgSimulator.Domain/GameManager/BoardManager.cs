using MtgSimulator.Cards;

namespace MtgSimulator.Domain.GameManager
{
    public class BoardManager
    {
        public PlayerGameState PlayerGameState;

        public BoardManager(ICardFactory cardFactory)
        {
            PlayerGameState = new PlayerGameState(cardFactory);
        }

        public void InitializeBoardManager(string deckCsvFilePath)
        {
            PlayerGameState.InitializeGameState(deckCsvFilePath);
        }
    }
}
