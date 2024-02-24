using System;
namespace InheritanceModifiers
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    } //end base class

    class Cat : Animal
    {
        protected string breed;
        public int legs;
        public string favFood;

        public void setBreed(string breed)
        {
            this.breed = breed;
        }
        public virtual string getBreed()
        {
            return this.breed;
        }

        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
    } //end cat class

    class Program
    {
        static void Main(string[] args)
        {
            Animal raccoon = new Animal();
            raccoon.setName("Bandit");
            raccoon.setType("Raccoon");
            raccoon.color = "gray and black";

            Console.WriteLine("Animal base class info...\n");
            Console.WriteLine($"My name is {raccoon.getName()}");
            Console.WriteLine($"I am a {raccoon.getType()}");
            Console.WriteLine($"I look {raccoon.color}");
            Console.WriteLine();

            Cat cat = new Cat();
            cat.setName("Freyja");
            cat.setType("house cat");
            cat.setBreed("domestic shorthair");
            cat.color = "gray";
            cat.legs = 4;
            cat.favFood = "tuna";

            Console.WriteLine("Derived cat animal class info...\n");
            Console.WriteLine($"My name is {cat.getName()}");
            Console.WriteLine($"I am a {cat.getType()}");
            Console.WriteLine($"I am a {cat.getBreed()} cat");
            Console.WriteLine($"I look {cat.color}");
            Console.WriteLine($"I have {cat.legs} legs");
            Console.WriteLine($"My favorite food is {cat.favFood}");
            Console.WriteLine();
        } //end Main
    } //end Program
} //end namespace