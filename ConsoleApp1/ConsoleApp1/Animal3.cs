using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal3
    {
        private string name;
        private string sound;

        public readonly int IdNum;
        public const string Shelter = "Derek's Home";
        public Animal3()
            :this("No Name","No Sound") { }

        public Animal3(string name)
            :this(name,"No Sound") { }
        public Animal3(string name,string sound) {
            SetName(name);
            Sound = sound;
            Random rnd = new Random();
            IdNum = rnd.Next(1, 21);
            NumberOfAnimals = 1;
        }

        public void makeSound()
        {
            Console.WriteLine("{0} says {1}",name,sound);
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
            set {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }
        public static int numOfAnimals = 0;
        public static int NumberOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }








    }
}
