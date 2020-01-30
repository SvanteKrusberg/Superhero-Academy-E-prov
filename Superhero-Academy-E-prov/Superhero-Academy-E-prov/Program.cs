using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_E_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createdHero = false;
            string userInput;
            //En lista där jag lagrar alla hjältar som skapas av användaren
            List<Hero> heroList = new List<Hero>();

            Console.WriteLine("What hero do you want to create?");
            Console.WriteLine("A: Offense Hero");
            Console.WriteLine("B: Defense Hero");
            Console.WriteLine("C: Support Hero");

            //En loop som körs så länge användaren inte gjort en hjälte
            while (createdHero == false)
            {
                userInput = Console.ReadLine().ToLower();
                if(userInput == "a")
                {
                    Console.WriteLine("What's the name of your hero?");

                    //Skapar och lägger till en hjälte i hjältelistan med rätt klass och med namn som användaren bestämt.
                    userInput = Console.ReadLine();
                    OffenseHero h1 = new OffenseHero(userInput);
                    heroList.Add(h1);
                    createdHero = true;
                    h1.PrintStats();
                }
                else if(userInput == "b")
                {
                    Console.WriteLine("What's the name of your hero?");

                    //Skapar och lägger till en hjälte i hjältelistan med rätt klass och med namn som användaren bestämt.
                    userInput = Console.ReadLine();
                    DefenseHero h1 = new DefenseHero(userInput);
                    heroList.Add(h1);
                    createdHero = true;
                    h1.PrintStats();
                }
                else if(userInput == "c")
                {
                    Console.WriteLine("What's the name of your hero?");

                    //Skapar och lägger till en hjälte i hjältelistan med rätt klass och med namn som användaren bestämt.
                    userInput = Console.ReadLine();
                    SupportHero h1 = new SupportHero(userInput);
                    heroList.Add(h1);
                    createdHero = true;
                    h1.PrintStats();

                }
                //En else som säger åt användaren att sluta vara jobbig
                else
                {
                    Console.WriteLine("Write a correct input.");
                }

            }

            //Kör PrintStats metoden gör hjälten som användaren har skapat
            heroList[0].PrintStats();
            Console.ReadLine();

        }
    }
}
