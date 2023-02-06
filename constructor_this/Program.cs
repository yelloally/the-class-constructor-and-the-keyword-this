using System;

namespace MiniGame
{
    // Class to store player information
    class Person
    {
        // Properties of the Person class
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Constructor for the Person class
        public Person(string name, int age, string address)
        {
            // Assign the constructor parameters to the class properties using the "this" keyword
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }
    }

    class Game
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Mini-Game!");

            // Get the player's name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            // Get the player's age
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // Get the player's address
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();

            // Create a new Person object with the player's information
            Person player = new Person(name, age, address);

            // Start the guessing game
            Console.WriteLine("Hi " + player.Name + "! Let's play a guessing game.");
            Console.WriteLine("Guess a number between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());

            // Generate a random number between 1 and 10
            int number = new Random().Next(1, 11);

            // Check if the player's guess is correct
            if (guess == number)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
            }
            else
            {
                Console.WriteLine("Sorry, the correct number was " + number + ".");
            }
        }
    }
}