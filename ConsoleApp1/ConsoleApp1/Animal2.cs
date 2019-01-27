using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal2
    {
        private string name;
        private string sound;

        public readonly int IdNum;

        public void makeSound() {
            Console.WriteLine("{0} says {1}",name,sound);
        }

        public const string Shelter = "Derek's Home";

        public Animal2()
            : this("No Name", "No Sound") { }
        public Animal2(string name)
            :this(name,"No SOund") { }

        public Animal2(string name,string sound)
        {
            SetName(name);
            Sound = sound;
            NumofAnimals = 1;
            Random rnd = new Random();
            IdNum = rnd.Next(1, 11);
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        public string GetName()
        {
            return name;
        }


        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;
        public static int NumofAnimals
        {
            get { return numOfAnimals; }
            set
            {
                numOfAnimals += value;
            }
        }



    }
}
