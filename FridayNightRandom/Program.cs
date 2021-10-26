using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandonMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            

            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandonMovie()
        {
            string[] films = { "Venom", "Harry Poter", "1+1", "Tenet" };
            
            Console.WriteLine($"Computer picked: {films[GenerateRandomIndex(films)]}");
        }
    }
}
