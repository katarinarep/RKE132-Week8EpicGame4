using System;
using System.IO;
    namespace Week8EpicGame4;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"/Users/katarina/projects/heroes.txt";
        string[] Week8EpicGame4 = File.ReadAllLines(filePath);
        foreach(string element in Week8EpicGame4)
        {
            Console.WriteLine(element);
        }
        //string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
        //string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
        //string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };


        //string hero = GetRandomValueFromArray(heroes);
        //string heroWeapon = GetRandomValueFromArray(weapon);
        //Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

        //string villain = GetRandomValueFromArray(villains);
        //string villainWeapon = GetRandomValueFromArray(weapon);
        //Console.WriteLine($"Today {villain} tries to take over the world!");

        //static string GetRandomValueFromArray(string[] someArray)
        {
            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, someArray.Length);
            //string randomStringFromArray = someArray[randomIndex];
            //return randomStringFromArray;
        }
    }
}

