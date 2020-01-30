using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_E_prov
{
    class SupportHero: Hero
    {
        private int mana;

        //En konstruktor som bestämmer namn och herotype på hjälten.
        public SupportHero(string n)
        {
            name = n;
            heroType = "Support Hero";

        }

        //En heal metod för support som kan användas för att heala (support duh) ;)
        public void Heal(int amount)
        {

        }

        public override void PrintStats()
        {
            //Kör den vanliga PrintStats metoden och sedan även det efter. Detta gör att jag kan ha i princip samma PrintStats + mana
            base.PrintStats();
            Console.WriteLine(mana);
        }

        public override void DealDamage(int amount)
        {
            
        }

        public override void TakeDamage(int amount)
        {
            
        }

    }
}
