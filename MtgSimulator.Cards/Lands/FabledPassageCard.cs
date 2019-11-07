using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class FabledPassageCard : Land
    {
        // TODO & TTA: how to handle fabled passage tappeness?
        public FabledPassageCard()
            : base("Fabled Passage", entersTapped: true, ManaSymbol.Blue, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
