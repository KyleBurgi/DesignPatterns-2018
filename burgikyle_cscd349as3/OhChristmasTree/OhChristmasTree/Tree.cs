using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhChristmasTree
{
    public abstract class Tree
    {
        public abstract int Cost();
        public abstract String GetDescription();
    }

    public class FraserTree : Tree
    {
        private String TreeType = "Fraser Fir has";
        private int TreeCost = 35;

        public override int Cost()
        {
            return this.TreeCost;
        }

        public override String GetDescription()
        {
            return this.TreeType;
        }
    }

    public class BalsamTree : Tree
    {
        private String TreeType = "Balsam Fir has";
        private int TreeCost = 25;

        public override int Cost()
        {
            return this.TreeCost;
        }

        public override string GetDescription()
        {
            return this.TreeType;
        }
    }

    public class DouglasTree : Tree
    {
        private String TreeType = "Douglas Fir has";
        private int TreeCost = 30;
        public override int Cost()
        {
            return this.TreeCost;
        }

        public override string GetDescription()
        {
            return this.TreeType;
        }
    }

    public class ColoradoBlueTree : Tree
    {
        private String TreeType = "Colorado Blue Spruce has";
        private int TreeCost = 50;
        public override int Cost()
        {
            return this.TreeCost;
        }

        public override string GetDescription()
        {
            return this.TreeType;
        }
    }



}
