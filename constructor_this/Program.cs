using System;

namespace thisMiniGame
{
    //class to store player information
    class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            //assign the constructor parameters to the class properties 
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }
    }

    class Game
    {
        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("Welcome to the Mini-Game!");

            //player's name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            //player's age
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            //player's address
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();

            //create a new Person object with the player's information
            Person player = new Person(name, age, address);

            //start the guessing game
            Console.WriteLine("Hi " + player.Name + "! Let's play a guessing game.");
            Console.WriteLine("Guess a number between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());

            //generate a random number between 1 and 10
            int number = new Random().Next(1, 11);

            //check if the player's guess is correct
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
