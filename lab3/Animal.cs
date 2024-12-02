using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р3
{
    public class Animal
    {
        private string name;
        private readonly DateTime birthDate;

        public Animal(string name)
        {
            this.name = name;
            birthDate = DateTime.Now;
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"{this.name}: move from {x} to {y}.");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
        }
    }
    public interface ISpeaking
    {
        void SpeakUp();
    }
    public class Dog : Animal, ISpeaking
    {
        public Dog(string name) : base(name) { }

        public void SpeakUp()
        {
            Console.WriteLine($"Dog: {this.Name} says: \"Woof-woof\".");
        }
    }
    public class Cat : Animal, ISpeaking
    {
        public Cat(string name) : base(name) { }

        public void SpeakUp()
        {
            Console.WriteLine($"Cat: {this.Name} says: \"Meow-meow\".");
        }
    }
}
