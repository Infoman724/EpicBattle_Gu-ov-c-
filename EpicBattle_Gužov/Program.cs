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
            string[] weapon = GetDatafromfile(folderPath + "weapons.txt");
            string[] armor = GetDatafromfile(folderPath + "armor.txt");

            string randomHero = GetRandomElement(heroes);
            string randomVillain = GetRandomElement(vilains);
            string heroarmor = GetRandomElement(armor);
            string villainarmor = GetRandomElement(armor);
            string heroWeapon = GetRandomElement(weapon);
            string villainWeapon = GetRandomElement(weapon);
            int villainHP = GenerateHP(villainarmor);
            int heroHP = GenerateHP(heroarmor);
            Console.WriteLine($"Your random hero is: {randomHero} in { heroarmor}" ); 
            Console.WriteLine($"Your random villain is: {randomVillain} in { villainarmor} ") ;
            Console.WriteLine($"{randomVillain} HP: {villainHP}");
            Console.WriteLine($"{randomHero} HP: {heroHP}");
            Console.WriteLine($"{randomHero} with {heroWeapon} will fight {randomVillain} with {villainWeapon}") ;

            while (heroHP >=0 && villainHP >=0)
            {
                heroHP = heroHP - Hit(randomVillain, villainWeapon);
                villainHP = villainHP - Hit(randomHero, heroWeapon);
            }
            if (heroHP > villainHP)
            {
                Console.WriteLine($"{randomHero} saves the day!");
            } else if (heroHP < villainHP)
            {
                Console.WriteLine($"Dark Side wins!");
            }
            else
            {
                Console.WriteLine($"Someday {randomHero} shall fight {randomVillain} again!");
            }

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

        public static int GenerateHP(string armor)
        {
            int characterHP = armor.Length;
            return characterHP;
        }
        public static int Hit(string character,string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length - 2);
            Console.WriteLine($"{character} deals {strike}!");
            if(strike==weapon.Length-2)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit");
            }   else if (strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed attack");
                
            }

            return strike;
        }

    }
}
