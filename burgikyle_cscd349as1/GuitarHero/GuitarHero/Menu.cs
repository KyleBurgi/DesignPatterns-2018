using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    interface IMenu
    {
        void PrintMenu();
    }

    public class SoloMenu : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Choose Solo 1-3, Otherwise Default");
            Console.WriteLine("Enter 1: Light Guitar on Fire!");
            Console.WriteLine("Enter 2: Jump off the Stage!");
            Console.WriteLine("Enter 3: Smash your Guitar!");
        }
    }

    public class GuitarMenu : IMenu
    {
        public void PrintMenu()
        {
                Console.WriteLine("Choose Guitar 1-4, Otherwise Default");
                Console.WriteLine("Enter 1: Fender Telecaster");
                Console.WriteLine("Enter 2: Fender Stratocaster");
                Console.WriteLine("Enter 3: Gibson SG");
                Console.WriteLine("Enter 4: Gibson Flying V");
         
        }
    }

    public class CharacterMenu : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Choose Character 1-4, Otherwise Default");
            Console.WriteLine("Enter 1: Angus Young");
            Console.WriteLine("Enter 2: Slash");
            Console.WriteLine("Enter 3: Jimi Hendrix");
            Console.WriteLine("Enter 4: CUSTOM");
        }
    }

}
