# Number Guess

A small .NET console game for practicing C#. The computer picks a number from 1 to 100, and you have seven guesses to find it.

## Run it

From this folder, run:

```sh
dotnet run
```

## What to notice

- `const` values hold the game's settings.
- `Random.Shared.Next` chooses the secret number.
- `while` repeats guesses; `if` statements decide what feedback to show.
- `int.TryParse` checks user input without crashing on invalid text.
- `ReadGuess` is a method that keeps input and validation together.
- `int?` allows the method to report that input has ended.

Try changing the number range or the number of allowed guesses, then run the game again.
