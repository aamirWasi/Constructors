using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Animal3 fox = new Animal3("Oscar", "rawwr");
            fox.makeSound();
            Console.WriteLine("{0}'s Id is {1}",
                fox.GetName(),
                fox.IdNum);

            Console.WriteLine("# of Animals {0}", Animal3.numOfAnimals);

            Animal3 cat = new Animal3();
            cat.SetName("Whisker");
            cat.Sound = "Meow";
            cat.makeSound();

            Console.WriteLine("# of Animals {0}", Animal3.numOfAnimals);
            Console.WriteLine("{0}'s Id is {1}",
                cat.GetName(),
                cat.IdNum);

            Console.WriteLine("{0} Shelter is {1}",
                cat.GetName(),
                Animal3.Shelter);
            /*
             
             Animal2 fox = new Animal2("Oscar", "rawwr");
            fox.makeSound();
            Console.WriteLine("{0}'s Id is {1}",
                fox.GetName(),
                fox.IdNum);

            Console.WriteLine("# of Animals {0}",Animal2.NumofAnimals);

            Animal2 cat = new Animal2();
            cat.SetName("Whisker");
            cat.Sound = "Meow";
            cat.makeSound();

            Console.WriteLine("# of Animals {0}", Animal2.NumofAnimals);
            Console.WriteLine("{0}'s Id is {1}",
                cat.GetName(),
                cat.IdNum);

            Console.WriteLine("{0} Shelter is {1}",
                cat.GetName(),
                Animal2.Shelter);
             
             */







            /*
             
             Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat named is {0} & says {1}",
                cat.GetName(),
                cat.Sound);
            //cat.Owner = "Derek";
            Console.WriteLine("{0}'s owner is {1}",
                cat.GetName(),
                cat.Owner);

            Console.WriteLine("{0}'s Shelter Id is {1}",
                cat.GetName(),
                cat.IdNum);

            Console.WriteLine("# of Animals {0}",
                Animal.NumofAnimals);
            Animal fox = new Animal("Oscar", "Rawwr");
            Console.WriteLine("# of Animals {0}",
                Animal.NumofAnimals);
             
             */
        }
    }
}
