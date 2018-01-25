using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    class GuitarHero
    {
        static void Main(string[] args)
        {
            Console.Write("Player One, Choose Options ");
            GameCharacter player1 = new GameCharacter();



            Console.Write("Player Two, Choose Options: ");
            GameCharacter player2 = new GameCharacter();

            String input;
            bool loop = true;
            while (loop)
            {
                Menu(player1, player2);
                input = Console.ReadLine();
                int SwitchNum = 0;
                bool result = int.TryParse(input, out SwitchNum);

                if (result)
                {
                    switch (SwitchNum)
                    {
                        case 1:
                            ChangeSoloTest(player1);
                            break;

                        case 2:
                            ChangeSoloTest(player2);
                            break;

                        case 3:
                            ChangeSoloTest(player1);
                            ChangeSoloTest(player2);
                            break;

                        case 4:
                            ChangeGuitarTest(player1);
                            break;

                        case 5:
                            ChangeGuitarTest(player2);
                            break;

                        case 6:
                            ChangeGuitarTest(player1);
                            ChangeGuitarTest(player2);
                            break;

                        case 99:
                            loop = false;
                            break;

                        default:
                            Play(player1, player2);
                            break;
                    }
                    
                }

                else
                    Play(player1, player2);
            }
        }

        public static void Menu(GameCharacter p1, GameCharacter p2)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("Enter 1: Change " + p1.Name +"'s Solo");
            Console.WriteLine("Enter 2: Change " + p2.Name + "'s Solo");
            Console.WriteLine("Enter 3: Change Both Player's Solo");
            Console.WriteLine("Enter 4: Change " + p1.Name +"'s Guitar");
            Console.WriteLine("Enter 5: Change " + p2.Name + "'s Guitar");
            Console.WriteLine("Enter 6: Change Both Player's Guiter");
            Console.WriteLine("Enter 99: EXIT APPLICATION");
            Console.WriteLine("Enter Any Other Number: Play Both Players Guitar and Solo");
        }

        public static void ChangeSoloTest(GameCharacter pi)
        {
            pi.SetSolo();
        }

        public static void ChangeGuitarTest(GameCharacter pi)
        {
            pi.SetGuitar();
        }

        public static void Play(GameCharacter player1, GameCharacter player2)
        {
            Console.WriteLine(player1.Name + "'s Turn!!!!");
            player1.PlayGuitar();
            player1.PlaySolo();

            Console.WriteLine("");
            Console.WriteLine(player2.Name + "'s Turn!!!");
            player2.PlayGuitar();
            player2.PlaySolo();
            Console.WriteLine("");
        }
    }
}
