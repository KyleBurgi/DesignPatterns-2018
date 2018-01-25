using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTheRing
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
    
    public class EyeOfSauron : IObservable
    {
        private Armies AttackingArmy;

        private List<IObserver> BadGuys = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            this.BadGuys.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.BadGuys.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver CurrentObserver in this.BadGuys)            
                CurrentObserver.Update();
            
        }

        public Armies GetArmy()
        {
            return this.AttackingArmy;
        }

        public void SetEnemies(Armies ApproachingArmy)
        {
            this.AttackingArmy = ApproachingArmy;
        }
    }
}
