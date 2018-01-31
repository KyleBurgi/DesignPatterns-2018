using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhChristmasTree
{
    class OhChristmasTree
    {
        static void Main(string[] args)
        {
            WriteLine("Oh Christmas Tree, Oh Christmas Tree...");

            Tree InitialChosenTree = ChooseTree();

            WriteLine("The " + InitialChosenTree.GetDescription() + " nothing on it! Why not add some decorations!");

            Tree FinalDecoratedTree = ChooseDecorations(InitialChosenTree);

            WriteLine("");
            WriteLine(FinalDecoratedTree.GetDescription() + " and will cost " + FinalDecoratedTree.Cost() + " Dollars.");

            ReadLine();
            Clear();
            PrintASCIITree();
            WriteLine("Thank you for your patronage and have a Happy Christmas!");

            ReadLine();
        }

        public static void PrintTreesMenu()
        {
            WriteLine("Enter 1-4 to Choose Your Tree: ");
            WriteLine("Enter 1: Fraser Fir");
            WriteLine("Enter 2: Balsam Fir");
            WriteLine("Enter 3: Douglas Fir");
            WriteLine("Enter 4: Colorado Blue Spruce");
        }

        public static Tree ChooseTree()
        {
            PrintTreesMenu();
            Tree ChosenTree = new BalsamTree();
            
            int MenuChoice = int.Parse(ReadLine());
            while (MenuChoice < 1 || MenuChoice > 4)
            {
                MenuChoice = int.Parse(ReadLine());
                WriteLine("Please enter a valid option");
            }

            switch (MenuChoice)
            {
                case 1:
                    ChosenTree = new FraserTree();
                    break;

                case 2:
                    ChosenTree = new BalsamTree();
                    break;

                case 3:
                    ChosenTree = new DouglasTree();
                    break;

                case 4:
                    ChosenTree = new ColoradoBlueTree();
                    break;

                default:
                    ChosenTree = new BalsamTree();
                    break;
            }

            return ChosenTree;
            
        }

        public static void PrintDecorationsMenu()
        {
            WriteLine("Enter 1 - 7 to add decorations");
            WriteLine("Enter 1: Star (Only One Per Tree.)");
            WriteLine("Enter 2: Ruffles");
            WriteLine("Enter 3: Red Baubles");
            WriteLine("Enter 4: Silver Baubles");
            WriteLine("Enter 5: Blue Baubles");
            WriteLine("Enter 6: Ribbons");
            WriteLine("Enter 7: Traditional Lights");
            WriteLine("Enter 8: LED Lights");
            WriteLine("Enter 0: Exit");
        }

        public static Tree ChooseDecorations(Tree ChosenTree)
        {
            PrintDecorationsMenu();

            bool SwitchMenu = true;

            int MenuChoice;

            while (SwitchMenu)
            {
                MenuChoice = int.Parse(ReadLine());
                while (MenuChoice < 0 || MenuChoice > 7)
                {
                    MenuChoice = int.Parse(ReadLine());
                    WriteLine("Please enter a valid option");
                }

                switch (MenuChoice)
                {
                    case 1:
                        ChosenTree = StarDecoration.GetStar(ChosenTree);
                        break;

                    case 2:
                        ChosenTree = new RufflesDecoration(ChosenTree);
                        WriteLine("Added a string of beautiful ruffles to the tree");
                        break;

                    case 3:
                        ChosenTree = new BallsRedDecoration(ChosenTree);
                        WriteLine("Added a dozen vibrant red baubles to the tree");
                        break;

                    case 4:
                        ChosenTree = new BallsSilverDecoration(ChosenTree);
                        WriteLine("Added a dozen spectacular silver baubles to the tree");
                        break;

                    case 5:
                        ChosenTree = new BallsBlueDecoration(ChosenTree);
                        WriteLine("Added a dozen shiny blue baubles to the tree");
                        break;

                    case 6:
                        ChosenTree = new RibbonsDecoration(ChosenTree);
                        WriteLine("Added a beautiful stream of Ribbons");
                        break;

                    case 7:
                        ChosenTree = new LightsDecoration(ChosenTree);
                        WriteLine("Added a string of traditional lights");
                        break;

                    case 8:
                        ChosenTree = new LEDLightsDecoration(ChosenTree);
                        WriteLine("Added a brand new string of LED lights");
                        break;


                    case 0:
                        SwitchMenu = false;
                        break;

                    default:
                        SwitchMenu = false;
                        break;
                }
            }

            return ChosenTree;
        }

        public static void PrintASCIITree()
        {
            WriteLine("        v");
            WriteLine("      > X < ");
            WriteLine("        A");
            WriteLine("       d$b");
            WriteLine("     .d\\$$b.");
            WriteLine("   .d$i$$\\$$b.");
            WriteLine("     d$$@b");
            WriteLine("    d\\$$$ib");
            WriteLine("   .d$$$\\$$$b");
            WriteLine(" .d$$@$$$$\\$$ib.");
            WriteLine("     d$$i$$b");
            WriteLine("    d\\$$$$@$b");
            WriteLine(" .d$@$$\\$$$$$@b.");
            WriteLine(".d$$$$i$$$\\$$$$$$b.");
            WriteLine("       ###");
            WriteLine("       ###");
            WriteLine("       ### ");
        }
    }

    

}
