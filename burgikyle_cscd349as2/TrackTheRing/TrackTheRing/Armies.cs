using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTheRing
{
    public class Armies
    {
        private int Hobbits;
        private int Elves;
        private int Dwarves;
        private int Humans;

        public Armies(int PIHobbits, int PIElves, int PIDwarves, int PIHumans)
        {

            this.Hobbits = PIHobbits;
            this.Elves = PIElves;
            this.Dwarves = PIDwarves;
            this.Humans = PIHumans;
        }

        public int GetHumans()
        {
            return this.Humans;
        }

        public int GetHobbits()
        {
            return this.Hobbits;
        }

        public int GetElves()
        {
            return this.Elves;
        }

        public int GetDwarves()
        {
            return this.Dwarves;
        }


        public void PrintArmies()
        {
            Console.WriteLine("The Army Consists of: "
                                + GetHobbits() + " Hobbits, "
                                + GetElves() + " Elves, "
                                + GetDwarves() + " Dwarves, and "
                                + GetHumans() + " Humans.");
        }
    }

    public class LeavingTheShire : Armies
    {
        private static int Hobbits = 4, Elves = 0, Dwarves = 0, Humans = 1;

        public LeavingTheShire() : base(Hobbits, Elves, Dwarves, Humans)
        {
            
        }

    }

    public class TheFellowship : Armies
    {
        private static int Hobbits = 4, Elves = 1, Dwarves = 1, Humans = 2;

        public TheFellowship() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }

    public class ArmyOfTheWest : Armies
    {
        private static int Hobbits = 2, Elves = 1, Dwarves = 0, Humans = 20000;

        public ArmyOfTheWest() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }
    
    public class ArmyFirstAge : Armies
    {
        private static int Hobbits = 0, Elves = 150000, Dwarves = 0, Humans = 100000;

        public ArmyFirstAge() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }
    
    public class ArmySecondAge : Armies
    {
        private static int Hobbits = 0, Elves = 40000, Dwarves = 20000, Humans = 40000;
        public ArmySecondAge() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }

    public class ArmyThirdAge : Armies
    {
        private static int Hobbits = 4, Elves = 150000, Dwarves = 1, Humans = 100000;

        public ArmyThirdAge() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }

    public class DefaultArmy : Armies
    {
        private static int Hobbits = 2, Elves = 0, Dwarves = 0, Humans = 0;

        public DefaultArmy() : base(Hobbits, Elves, Dwarves, Humans)
        { }
    }



}
