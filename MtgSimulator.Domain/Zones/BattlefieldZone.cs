using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.Cards.Interfaces;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Zones
{
    public class BattlefieldZone
    {
        public IList<IPermanent> Cards { get; private set; }

        public BattlefieldZone()
        {
            Cards = new List<IPermanent>();
        }

        public void ClearBattlefield()
        {
            Cards.Clear();
        }

        public void PutPermanentOnTheBattlefield(IPermanent permanent)
        {            
            Cards.Add(permanent);
            permanent.OnEntersTheBattlefield();
        }
    }
}
