using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{

    public class GameCharacter
    {
        IMenu menu = null;
        private String name;
        public String Name
        {
            get {return this.name; }
            set {this.name = value; }
        }
        private IGuitar guitar;
        private ISolo solo;

        public GameCharacter()
        {
            this.name = ChooseCharacter();
            this.guitar = ChooseGuitar();
            this.solo = ChooseSolo();
        }

        public void PlayGuitar()
        {
            guitar.Model();
        }

        public void PlaySolo()
        {
            Console.Write(this.name);
            solo.PlaySolo();
        }


        public void SetGuitar()
        {
            String name = this.Name;
            Console.WriteLine(name + ", Choose your new guitar!");
            this.guitar = ChooseGuitar();
        }

        public void SetCharacter()
        {
            this.name = ChooseCharacter();
        }

        public void SetSolo()
        {
            String name = this.Name;
            Console.WriteLine(name + ", Choose your new solo!");
            this.solo = ChooseSolo();
        }


        private ISolo ChooseSolo()
        {
            ISolo SickSolo = null;
            menu = new SoloMenu();
            menu.PrintMenu();
            String input = Console.ReadLine();
            int SwitchNum = 0;
            bool result = int.TryParse(input, out SwitchNum);

            if (result)
            {
                switch (SwitchNum)
                {
                    case 1:
                        SickSolo = new SoloFire();
                        break;

                    case 2:
                        SickSolo = new SoloJump();
                        break;

                    case 3:
                        SickSolo = new SoloSmash();
                        break;

                    default:
                        SickSolo = new DefaultSolo();
                        break;
                }
                return SickSolo;
            }
            else
                return new DefaultSolo();
        }

        private IGuitar ChooseGuitar()
        {
            IGuitar ChosenOne = null;
            menu = new GuitarMenu();
            menu.PrintMenu();
            String input = Console.ReadLine();
            int SwitchNum = 0;
            bool result = int.TryParse(input, out SwitchNum);

            if (result)
            {
                switch (SwitchNum)
                {
                    case 1:
                        ChosenOne = new Fender();
                        break;

                    case 2:
                        ChosenOne = new Stratocaster();
                        break;

                    case 3:
                        ChosenOne = new Gibson();
                        break;

                    case 4:
                        ChosenOne = new Gibson2();
                        break;

                    default:
                        ChosenOne = new DefaultGuitar();
                        break;
                }
                return ChosenOne;
            }
            else
                return new DefaultGuitar();
        }

        private String ChooseCharacter()
        {
            String name = "";
            menu = new CharacterMenu();
            menu.PrintMenu();
            String input = Console.ReadLine();
            int SwitchNum = 0;
            bool result = int.TryParse(input, out SwitchNum);

            if (result)
            {
                switch (SwitchNum)
                {
                    case 1:
                        name = "Angus Young";
                        break;

                    case 2:
                        name = "Slash";
                        break;

                    case 3:
                        name = "Jimi Hendrix";
                        break;

                    case 4:
                        Console.WriteLine("Enter Custom Name");
                        name = Console.ReadLine();
                        break;

                    default:
                        name = "Eeyore";
                        break;
                }
                return name;
            }
            else
                return "Eeyore";
        }  

      }  
}

