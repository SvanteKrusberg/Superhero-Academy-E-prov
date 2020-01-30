using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_E_prov
{
    class Hero
    {
        //Basvariablar som kommer behövas för alla olika hjältar. Dessa ärvs av de olika sub-klasserna
        protected string name;
        protected string heroType;
        protected int hp;
        protected int attack;
        protected int defence;

        //En metod som körs när hjälten tar skada, denna är virtual då olika sub-klasser tar olika mycket skada
        public virtual void TakeDamage(int amount)
        {

        }

        //En metod som körs när hjälten gör skada, denna är virtual då olika sub-klasser gör olika mycket skada
        public virtual void DealDamage(int amount)
        {

        }

        //En metod för att skriva ut hjältens stats, denna är virtual då sub-klasser har några olika stats som måste visas
        //exempelvis: mana, energy och stamina
        public virtual void PrintStats()
        {
            Console.WriteLine(name);
            Console.WriteLine(heroType);
        }

    }



}
