using System;

 

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello, World!");

        GreetUser("Student");

    }

 

    static void GreetUser(string name)

    {

        Console.WriteLine($"Hello, {name}!");

    }

}
