using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    interface IGuitar
    {
        void Model();
        String GetModel();
    }

    public class Stratocaster : IGuitar
    {
        private String GuitarModel = "Stratocaster";

        public String GetModel()
        {
            return this.GuitarModel;
        }

        public void Model()
        {
            Console.WriteLine(GetModel());
        }
    }

    public class Fender : IGuitar
    {
        private String GuitarModel = "Fender Telecaster";

        public void Model()
        {
            Console.WriteLine("Currently Using: " + GetModel());
        }

        public String GetModel()
        {
            return this.GuitarModel;
        }
    }

    public class Gibson : IGuitar
    {
        private String GuitarModel = "Gibson SG";

        public void Model()
        {
            Console.WriteLine(GetModel());
        }

        public String GetModel()
        {
            return this.GuitarModel;
        }
    }

    public class Gibson2 : IGuitar
    {
        private String GuitarModel = "Gibson Flying V";

        public void Model()
        {
            Console.WriteLine(GetModel());
        }

        public String GetModel()
        {
            return this.GuitarModel;
        }
    }

    public class DefaultGuitar : IGuitar
    {
        private String GuitarModel = "Boring Acoustic Guitar";

        public void Model()
        {
            Console.WriteLine(GetModel());
        }

        public String GetModel()
        {
            return this.GuitarModel;
        }
    }


}
