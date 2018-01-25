using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTheRing
{
    public interface IObserver
    {
        void Update();
        
    }

    public interface IDisplay
    {
        void Display();
    }

    public class Saruman : IObserver, IDisplay
    {
        private EyeOfSauron Eye= new EyeOfSauron();
        private Armies CurrentArmy = new DefaultArmy();

        public Saruman(EyeOfSauron EyeOfSauron)
        {
            this.Eye = EyeOfSauron;
        }
        public void Update()
        {
            this.CurrentArmy = this.Eye.GetArmy();
        }

        public void Display()
        {
            Console.WriteLine("The Army Consists of: "
                                  + CurrentArmy.GetHobbits() + " Hobbits, "
                                  + CurrentArmy.GetElves() + " Elves, "
                                  + CurrentArmy.GetDwarves() + " Dwarves, and "
                                  + CurrentArmy.GetHumans() + " Humans.");
        }
    }

    public class TheWitchKing : IObserver, IDisplay
    {
        private EyeOfSauron Eye = new EyeOfSauron();
        private Armies CurrentArmy = new DefaultArmy();

        public TheWitchKing(EyeOfSauron EyeOfSauron)
        {
            this.Eye = EyeOfSauron;
        }

        public void Update()
        {
            this.CurrentArmy = this.Eye.GetArmy();
        }

        public void Display()
        {
            Console.WriteLine("The Army Consists of: "
                                  + CurrentArmy.GetHobbits() + " Hobbits, "
                                  + CurrentArmy.GetElves() + " Elves, "
                                  + CurrentArmy.GetDwarves() + " Dwarves, and "
                                  + CurrentArmy.GetHumans() + " Humans.");
        }
    }

    

    
}
