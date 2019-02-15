using System;

namespace nelnet_pet_finder
{
    class OutputMessages
    {
        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Pet Finder!!!\n");
        }

        public static string WannaPlay()
        {
            Console.WriteLine("Want to find your perfect match (y/n)?");
            return CommonFunctions.CleanYesNoAnswer(Console.ReadLine().ToUpper());
        }

        public static void ReturnAgain()
        {
            Console.WriteLine("\nThanks for visiting and come back again.");
            Console.ReadLine();
        }

        public static void WrongAnswer()
        {
            Console.WriteLine("Please answer Y or N\n");
        }

        public static string EnterName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
        public static string PreferredPetClass()
        {
            Console.WriteLine("What class of animal would you like to find (i.e. Mammal, Arachnid, Reptile, etc...)? If multiple, please seperate by commas.");
            return Console.ReadLine().ToUpper();
        }
        public static string PreferredPetType()
        {
            Console.WriteLine("What type of animal based on the classification (i.e. Cat, Dog, Goldfish, Parrot, etc...)?  If multiple, please seperate by commas.");
            return Console.ReadLine().ToUpper();
        }

        public static void ResultsOutput(string name)
        {
            Console.WriteLine($"Pets for {name}:\n");
        }

        public static void PetMatchOutput(string name, bool result)
        {
            string goodBad = result == true ? "good" : "bad";
            Console.WriteLine($"{name} would be a {goodBad} pet");
        }
    }
}
