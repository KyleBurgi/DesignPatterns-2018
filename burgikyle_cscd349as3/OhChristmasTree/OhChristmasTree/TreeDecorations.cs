using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhChristmasTree
{
    public abstract class TreeDecorations : Tree
    {
        
    }

    public class StarDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 4;
        private String DecorationDescription = ", a bright shining Star ";

        private StarDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }

        public static Tree GetStar(Tree PassedInTree)
        {
            if (!PassedInTree.GetDescription().Contains("Star"))
            {
                PassedInTree = new StarDecoration(PassedInTree);
                Console.WriteLine("Added a Star to the top of the tree!");
                return PassedInTree;
            }

            Console.WriteLine("There is already a bright, shining star on the tree!");
            return PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }
        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }

    public class RufflesDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 1;
        private String DecorationDescription = ", some Ruffles";

        public RufflesDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }
    
    public class BallsRedDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 1;
        private String DecorationDescription = ", a dozen Red Baubles ";

        public BallsRedDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }
    
    public class BallsSilverDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 3;
        private String DecorationDescription = ", a dozen Silver Baubles ";

        public BallsSilverDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }
    
    public class BallsBlueDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 2;
        private String DecorationDescription = ", a dozen Blue Baubles ";

        public BallsBlueDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }

    public class RibbonsDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 2;
        private String DecorationDescription = ", a frollic of Ribbons ";

        public RibbonsDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }

    public class LightsDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 5;
        private String DecorationDescription = ", a string of Traditional Lights ";

        public LightsDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + " " + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }

    public class LEDLightsDecoration : TreeDecorations
    {
        private Tree BaseTree;
        private int DecorationCost = 10;
        private String DecorationDescription = ", a string of LED Lights ";

        public LEDLightsDecoration(Tree PassedInTree) : base()
        {
            this.BaseTree = PassedInTree;
        }
        public override string GetDescription()
        {
            return this.BaseTree.GetDescription() + this.DecorationDescription;
        }

        public override int Cost()
        {
            return this.BaseTree.Cost() + this.DecorationCost;
        }
    }
}
