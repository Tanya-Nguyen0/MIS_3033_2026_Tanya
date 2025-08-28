//generate a random number between 1 and 5
using System;

//Datatype variable = value;
Random rand = new Random();
int randomNumber = rand.Next(1, 6); // generates a random number between 1 and 5

int guess;
do
{
    Console.WriteLine("Please guess a number between 1 and 5:");
    string userGuess = Console.ReadLine();

    guess = int.Parse(userGuess);
    guess = Convert.ToInt32(userGuess);
    Console.WriteLine($"You guessed: {userGuess}");

    if (randomNumber == guess)
    {
        Console.WriteLine("Congratulations! You guessed the correctly!");
    }
    else
    {
        Console.WriteLine("Sorry, you guessed incorrectly. Better luck next time!");
    }

} while (randomNumber != guess);

Console.WriteLine("We generated the random number " + randomNumber + ".");

