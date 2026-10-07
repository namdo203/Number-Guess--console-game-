const int minimumNumber = 1;
const int maximumNumber = 100;
const int maximumAttempts = 7;

int secretNumber = Random.Shared.Next(minimumNumber, maximumNumber + 1);
int attempts = 0;
bool hasWon = false;

Console.WriteLine("Welcome to Number Guess!");
Console.WriteLine($"I'm thinking of a number from {minimumNumber} to {maximumNumber}.");
Console.WriteLine($"You have {maximumAttempts} guesses.");

while (attempts < maximumAttempts)
{
    int? guess = ReadGuess(attempts + 1, maximumAttempts, minimumNumber, maximumNumber);
    if (guess is null)
    {
        Console.WriteLine("\nNo more input. Thanks for playing!");
        return;
    }

    attempts++;

    if (guess == secretNumber)
    {
        hasWon = true;
        Console.WriteLine($"You got it in {attempts} {(attempts == 1 ? "guess" : "guesses")}!");
        break;
    }

    Console.WriteLine(guess < secretNumber ? "Too low!" : "Too high!");
}

if (!hasWon)
{
    Console.WriteLine($"Out of guesses! The number was {secretNumber}.");
}

static int? ReadGuess(int attempt, int maximumAttempts, int minimumNumber, int maximumNumber)
{
    while (true)
    {
        Console.Write($"Guess {attempt} of {maximumAttempts}: ");
        string? input = Console.ReadLine();

        if (input is null)
        {
            return null;
        }

        if (int.TryParse(input, out int guess) &&
            guess >= minimumNumber &&
            guess <= maximumNumber)
        {
            return guess;
        }

        Console.WriteLine($"Enter a whole number from {minimumNumber} to {maximumNumber}.");
    }
}
