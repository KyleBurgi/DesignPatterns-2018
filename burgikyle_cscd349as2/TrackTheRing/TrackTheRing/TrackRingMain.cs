using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTheRing
{
    class TrackRingMain
    {
        static void Main(string[] args)
        {
            EyeOfSauron Eye = new EyeOfSauron();
            Saruman SarumanSees = new Saruman(Eye);
            TheWitchKing WitchKingSees = new TheWitchKing(Eye);

            Eye.RegisterObserver(SarumanSees);
            Eye.RegisterObserver(WitchKingSees);
            int TurnCount = 0;
            
            bool play = true;


            WriteLine("GRADER NOTE: This will run for only six turns.\nThis gives you enough time to transition to each of the Army options.");
            while(play)
            {
                Armies ArmyChoice = ChooseArmy();

                Eye.SetEnemies(ArmyChoice);
                Eye.NotifyObservers();

                if (ArmyChoice != null)
                {
                    if (TurnCount < 3)
                    {
                        WriteLine("Saruman sees on the horizon...");
                        SarumanSees.Display();
                        WriteLine("\n\n");
                    }
                    
                    WriteLine("The Witch King sees on the horizon...");
                    WitchKingSees.Display();
                    WriteLine("\n\n");
                }
               

                if (TurnCount == 3)
                {
                    Eye.RemoveObserver(SarumanSees);
                    WriteLine("Saruman Has Died. He No Longer Sees.");
                    WriteLine("\n\n");
                }

                else if (TurnCount > 6)
                {
                    Eye.RemoveObserver(WitchKingSees);
                    WriteLine("The Witch King Has Died. He No Longer Sees.");
                    WriteLine("\n\n");
                    play = false;
                    break;
                }

                else if (ArmyChoice == null)
                {
                    play = false;
                    break;
                }
                TurnCount++;
            }

            if (SarumanSees == null || WitchKingSees == null)
            {
                WriteLine("The armies of man have won.");
            }

            else
            {
                WriteLine("Exiting...");
            }

            ReadLine();

        }

        public static Armies ChooseArmy()
        {
            PrintArmyMenu();

            Armies ArmyChoice = null;
            String input = Console.ReadLine();
            int SwitchNum = 0;
            bool result = int.TryParse(input, out SwitchNum);

            WriteLine("\n");
            if (result)
            {
                switch (SwitchNum)
                {
                    case 1:
                        ArmyChoice = new LeavingTheShire();
                        break;

                    case 2:
                        ArmyChoice = new TheFellowship();
                        break;

                    case 3:
                        ArmyChoice = new ArmyOfTheWest();
                        break;

                    case 4:
                        ArmyChoice = new ArmyFirstAge();
                        break;

                    case 5:
                        ArmyChoice = new ArmySecondAge();
                        break;

                    case 6:
                        ArmyChoice = new ArmyThirdAge();
                        break;


                    case 7:
                        ArmyChoice = null;
                        break;
                    
                    default:
                        ArmyChoice = new DefaultArmy();
                        break;
                }
                return ArmyChoice;
            }
            return ArmyChoice;
        }



        public static void PrintArmyMenu()
        {
            WriteLine("Enter Number for Army: ");
            WriteLine("Enter 1:  Leaving The Shire");
            WriteLine("Enter 2:  The Fellowship");
            WriteLine("Enter 3:  Armies of the West");
            WriteLine("Enter 4:  War of Wrath in the First Age");
            WriteLine("Enter 5:  War of the Last Alliance in the Second Age");
            WriteLine("Enter 6:  War of the Ring in the Third Age");
            WriteLine("Enter 7:  For Other Options");

        }
    }
}
