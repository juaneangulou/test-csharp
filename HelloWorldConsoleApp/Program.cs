// See https://aka.ms/new-console-template for more information
using HelloWorldConsoleApp.Dtos;

public static class SayHello
{
    public static void Main (){

        Console.WriteLine("Hola mundo!");
        var person = new Person();
        person.Name = "Jhon";
        person.Age = 18;

        string message = $"Hello Mr {person.Name} your age is {person.Age}";
        Console.WriteLine(message);
        Console.ReadLine();
    }
}

