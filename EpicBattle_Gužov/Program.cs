using System;
using System.IO;
namespace EpicBattle_Gužov
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] heroes = { "Harry Potter", "Superman", "Luke Skywalker", "Lara Croft" };
            //string[] villains = { "Voldemort", "Joker", "Venom", "Darth Vader", "Cruella" };
            string folderPath = @"D:\samples\";
            string[] heroes = GetDatafromfile(folderPath + "heroes.txt");
            string[] vilains = GetDatafromfile(folderPath + "vilains.txt");


            string randomHero = GetRandomElement(heroes);
            string randomVillain = GetRandomElement(vilains);
            string heroWeapon = ;
            string villainWeapon = ;
            Console.WriteLine($"Your random hero is: {randomHero}");
            Console.WriteLine($"Your random villain is: {randomVillain}");
        }

        public static string GetRandomElement(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;
        }
        public static string[] GetDatafromfile(string filePath) {
            string[] dataFromlfile = File.ReadAllLines(filePath);
            return dataFromlfile;



        }
       

        
    }
}
