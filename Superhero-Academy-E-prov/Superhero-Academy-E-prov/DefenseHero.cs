using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_E_prov
{
    class DefenseHero: Hero
    {
        private int stamina;

        public DefenseHero(string n)
        {
            name = n;
            heroType = "Defense Hero";
        }

        public override void TakeDamage(int amount)
        {

        }

        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine(stamina);
        }

    }
}
