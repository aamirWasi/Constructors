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
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat named is {0} & says {1}",
                cat.GetName(),
                cat.Sound);
            cat.Owner = "Derek";
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
        }
    }
}
