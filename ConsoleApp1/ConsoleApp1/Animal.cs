using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        private string name;
        private string sound;

        public const string Shelter = "Derek's Home for Animal";
        public readonly int IdNum;
        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public Animal()
            : this("No Name", "No Sound") { }
        public Animal(string name)
            :this(name,"No Sound") { }
        public Animal(string name,string sound)
        {
            SetName(name);
            Sound = sound;
            NumofAnimals = 1;
            Random rnd = new Random();
            IdNum = rnd.Next(1, 2147483640);

        }
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
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
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too Long");
                }
                sound = value;
            }
        }
        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;
        public static int NumofAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }

    }
}
