# Create C# Logic for a Basketball Game App (Solution)

## Prerequisites

This activity requires you to create code in Visual Studio. You can use the **C# Console Application** template to complete the exercises in this activity. Enter your code within the `Main` method of the template and press `Ctrl` + `F5` to run the program without debugging.

## Instructions

In this activity, you'll use C# to create basic app logic for the basketball game. Each exercise reflects logic that could be used in a script for game play.

1. Create a `player` variable for the app's player and assign your name to the variable.

    ```csharp
    string player = "Gustavo";
    ```

1. The `player` must have possession of the basketball to take a shot. If the `player` does not have the basketball, then they must wait to take another shot. When the game starts, the `player` has possession of the basketball up until they shoot the basketball. Create a conditional statement that outputs a string that indicates whether the `player` can or cannot take a shot.

    ```csharp
    bool hasPossession = true;
    
    if (hasPossession == true)
    {
        Console.WriteLine("Player can take the shot.");
    }
    else
    {
        Console.Write("Player cannot take the shot.");
    }
    ```

1. Create a `score` variable for the total number of points received from a successful basketball shot.

    ```csharp
    int score;
    ```

1. When the game starts, the `score` is set to `0`. Each time the `player` makes a successful shot, their `score` increases by `1` point. Create a `TakeShot` method that increments the player's `score` by `1` point if their shot is successful.

    ```csharp
    static void TakeShot()
    {
        int score = 0;
        bool shotSuccessful = false;

        if (shotSuccessful == true)
        {
            score++;
        }
    }
    ```

1. The `player` has `5` chances to make a shot. After their 5th shot, the game is over. Create a while loop that executes the `TakeShot` method until the `player` has taken their 5th shot.

    ```csharp
    int numShots = 5;
    
    while (numShots > 0)
    {
        TakeShot();
    }
    ```

1. When the game is over, the total `score` is output for the `player`. Use the `Console.WriteLog()` command to create a string that outputs the player's name and `score`.

    ```csharp
    Console.WriteLine(player + " has scored " + score + " points!");
    ``````

## Bonus

Without a game in play, it can be a challenge to verify whether the program you created is valid. However, there's a way to programmatically simulate game play! The `ConsoleReadLine()` command accepts input and stores the value to a variable within the program. Once the value is stored, the program can use the value as it continues to execute the script.

Using `ConsoleReadLine()`, modify the program you created to simulate game play. Use `ConsoleReadLine()` to do the following:

- Ask and assign the player's name to the `player` value. Welcome the player and inform them that the game is about to start.
- Confirm whether the player's shot was successful. If the player makes the shot, then increase their score by `1` point. If the player doesn't make the shot, then tell the player to try again.
- Once game is over, print the player's final score to the console.

```csharp
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?: ");

        string player = Console.ReadLine();

        Console.WriteLine("Welcome " + player + "! The game starts in 3...2...1..Go!");

        TakeShot();
    }

    static void TakeShot()
    {
        int numShots = 5;
        int score = 0;

        while (numShots > 0)
        {
            Console.WriteLine("Did you make the shot? (Y/N) ");
            string shotResponse = Console.ReadLine();

            if (shotResponse == "Y")
            {
                score++;
                numShots--;
            }
            else
            {
                numShots--;
                Console.WriteLine("Try again.");
            }

        }
        
        Console.WriteLine("Game Over! You scored " + score + " points!");
    }
}
```