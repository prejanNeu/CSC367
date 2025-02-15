using System;

namespace Lab7
{
    abstract class Parent
    {

        public abstract void Display();

        public void Show ()
        {
            Console.WriteLine("From parent class ");
        }

    }
    class Child : Parent 
    {
        public override void Display()
        {
            Console.WriteLine("From child class ");
        }
    }

    interface MakeSound
    {
        void MakeSound();
    }
    interface Eat
    {
        void Eat();
    }
    class Dog : MakeSound,Eat
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog Barks ");
        }
        public void Eat()
        {
            Console.WriteLine("Dog is eating ");
        }

        public static void Main(string[] args )
        {
            Console.WriteLine("<-------Abstract class-------->");

            Child child = new Child();

            child.Display();
            child.Show();


            Console.WriteLine("<-------Multiple Inheritance using Interface---------->");

            Dog dog = new Dog();
            dog.Eat();
            dog.MakeSound();

            Console.WriteLine("Prejan Neupane\n28073/078");

        }
    }

}