using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_E_prov
{
    class OffenseHero: Hero
    {
        private int energy;

        public OffenseHero(string n)
        {
            name = n;
            heroType = "Offense Hero";
        }

        public override void DealDamage(int amount)
        {

        }
        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine(energy);
        }

    }
}
