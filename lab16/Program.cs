using System;
using System.Reflection;
using System.Runtime.InteropServices;

// (a) Built-in Attributes Usage
[Serializable] // Marks this class as serializable
class Person
{
    public string Name;
    public int Age;
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    // Using [Obsolete] attribute to mark this method as deprecated
    [Obsolete("Use NewMethod() instead.")]
    public static void OldMethod()
    {
        Console.WriteLine("This is an old method.");
    }

    public static void NewMethod()
    {
        Console.WriteLine("This is the new method.");
    }

    // (b) Creating a Custom Attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class DeveloperInfo : Attribute
    {
        public string Developer { get; }
        public string Date { get; }

        public DeveloperInfo(string developer, string date)
        {
            Developer = developer;
            Date = date;
        }
    }

    // Applying custom attribute to class
    [DeveloperInfo("Prejan Neupane", "2025-02-20")]
    class SampleClass
    {
        [DeveloperInfo("Another Dev", "2025-02-19")]
        public void TestMethod()
        {
            Console.WriteLine("Method executed.");
        }
    }

    static void Main()
    {
        // (a) Demonstrating Built-in Attributes
        OldMethod(); // This will show a warning due to [Obsolete]
        NewMethod();

        // (b) Retrieving Custom Attribute Using Reflection
        Type type = typeof(SampleClass);
        object[] classAttributes = type.GetCustomAttributes(typeof(DeveloperInfo), false);

        foreach (DeveloperInfo attr in classAttributes)
        {
            Console.WriteLine($"Class Attribute - Developer: {attr.Developer}, Date: {attr.Date}");
        }

        MethodInfo method = type.GetMethod("TestMethod");
        object[] methodAttributes = method.GetCustomAttributes(typeof(DeveloperInfo), false);

        foreach (DeveloperInfo attr in methodAttributes)
        {
            Console.WriteLine($"Method Attribute - Developer: {attr.Developer}, Date: {attr.Date}");
        }
    }
}
