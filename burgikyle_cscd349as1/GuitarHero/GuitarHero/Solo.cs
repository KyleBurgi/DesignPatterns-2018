using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    interface ISolo
    {
        void PlaySolo();
    }

    public class SoloFire : ISolo
    {
        public void PlaySolo()
        {
            Console.WriteLine("'s Guitar is on Fire!!!");
        }
    }

    public class SoloJump : ISolo
    {
        public void PlaySolo()
        {
            Console.WriteLine(" Jumped off the Stage!!!");
        }
    }

    public class SoloSmash : ISolo
    {
        public void PlaySolo()
        {
            Console.WriteLine("'s Guitar was Smashed to bits!!!");
        }
    }

    public class DefaultSolo : ISolo
    {
        public void PlaySolo()
        {
            Console.WriteLine(" jumped up and down for a bit. Boring.");
        }
    }
}
