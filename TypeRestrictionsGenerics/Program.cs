using System;

namespace TypeRestrictionsGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var duck = new GenericSwimmingAnimal<Duck>();
            Console.WriteLine($"Duck can: {duck.MakeSoundAndSwim()}");
        }
    }//end Program

    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public interface ICanSwim
    {
        string Swim();
    }

    public class GenericSwimmingAnimal<T> where T : Animal, ICanSwim , new()
    {
        public string MakeSoundAndSwim()
        {
            T animal = new T();
            return $"{animal.MakeSound()} and {animal.Swim()}";
        }
    }

    public class Duck : Animal, ICanSwim
    {
        public override string MakeSound()
        {
            return "Quack";
        }

        public string Swim()
        {
            return "Swim in the pond";
        }
 
    }






}
