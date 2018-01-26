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

            Tree Fraser = new FraserTree();
            WriteLine(Fraser.GetDescription() + " costs " + Fraser.Cost());

            Tree Balsam = new BalsamTree();
            WriteLine(Balsam.GetDescription() + " costs " + Balsam.Cost());

            Tree Colorado = new ColoradoBlueTree();
            WriteLine(Colorado.GetDescription() + " costs " + Colorado.Cost());

            Tree Douglas = new DouglasTree();
            WriteLine(Douglas.GetDescription() + " costs " + Douglas.Cost());

            String temp = ReadLine();
        }
    }
}
