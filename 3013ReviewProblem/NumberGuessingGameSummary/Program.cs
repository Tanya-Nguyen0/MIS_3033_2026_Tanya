//generate a random number between 1 and 5
using System;

//Datatype variable = value;
Console.WriteLine("Welcome to our Game!");

Console.WriteLine("Please input the lower bound value (lower values that could be guessed):");
string answer = Console.ReadLine();
int lowerBound = ValidateInput(answer);

int ValidateInput(string input)
{
    int ConvertValue = 0;
    while (int.TryParse(answer, out ConvertValue) == false)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer:");
        answer = Console.ReadLine();
    }
    return ConvertValue;
}

Console.WriteLine("Please input the upper bound value (higher values that could be guessed):");
string answer2 = Console.ReadLine();
int upperBound = ValidateInput(answer2);
for (int i = 0; i < lowerBound; i++) ;







//string answer = Console.ReadLine();
//int lowerBound = int.Parse(answer);

//Console.WriteLine("Please input the upper bound value (higher values that could be guessed:");
//string answer2 = Console.ReadLine();
//int upperBound = int.Parse(answer2);

//for (int i = lowerBound; i <= upperBound; i++)
//{
//    Random random = new Random();
//    int randomNumberInRange = random.Next(lowerBound, upperBound + 1); // generates a random number between lowerBound and upperBound
//    int guessInRange;
//    int NumberofGuesses = 0;
//    do
//    {
//        Console.WriteLine($"Please guess a number between {lowerBound} and {upperBound}:");
//        string userGuessInRange = Console.ReadLine();
//        // Validate input before parsing
//        while (string.IsNullOrWhiteSpace(userGuessInRange) || !int.TryParse(userGuessInRange, out guessInRange))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer:");
//            userGuessInRange = Console.ReadLine();
//        }
//        NumberofGuesses++;
//        Console.WriteLine($"You guessed: {userGuessInRange}");
//        if (randomNumberInRange == guessInRange)
//        {
//            Console.WriteLine($"Congratulations! You guessed the correctly in {NumberofGuesses} guesses!");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, you guessed incorrectly. Better luck next time!");
//        }
//    } while (randomNumberInRange != guessInRange);

//}

//Random rand = new Random();
//int randomNumber = rand.Next(1, 6); // generates a random number between 1 and 5

//int guess;
//do
//{
//    Console.WriteLine("Please guess a number between 1 and 5:");
//    string userGuess = Console.ReadLine();

//    guess = int.Parse(userGuess);
//    guess = Convert.ToInt32(userGuess);
//    Console.WriteLine($"You guessed: {userGuess}");

//    if (randomNumber == guess)
//    {
//        Console.WriteLine("Congratulations! You guessed the correctly!");
//    }
//    else
//    {
//        Console.WriteLine("Sorry, you guessed incorrectly. Better luck next time!");
//    }

//} while (randomNumber != guess);

//Console.WriteLine("We generated the random number " + randomNumber + ".");

