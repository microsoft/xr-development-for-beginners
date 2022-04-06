# Create C# Logic for a Basketball Game App

## Prerequisites

This activity requires you to create code in Visual Studio. You can use the **C# Console Application** template to complete the exercises in this activity. Enter your code within the `Main` method of the template and press `Ctrl` + `F5` to run the program without debugging.

## Instructions

In this activity, you'll use C# to create basic app logic for the basketball game. Each exercise reflects logic that could be used in a script for game play.

1. Create a `player` variable for the app's player.
1. The `player` must have possession of the basketball to take a shot. If the `player` does not have the basketball, then they must wait to take another shot. When the game starts, the `player` has possession of the basketball up until they shoot the basketball. Create a conditional statement that reflects what happens if the `player` does not have the basketball in their possession.
1. Create a `score` variable for the total number of points received from a successful basketball shot.
1. When the game starts, the `score` is set to `0`. Each time the `player` makes a successful shot, their `score` increases by `1` point. Create a `TakeShot` method that increments the player's `score` by `1` point if their shot is successful.
1. The `player` has `5` chances to make a shot. After their 5th shot, the game is over. Create a while loop that executes the `TakeShot` method until the `player` has taken their 5th shot.
1. When the game is over, the total `score` is output for the `player`. Use the `Console.WriteLog()` command to create a string that outputs the player's name and `score`.

## Bonus

Without a game in play, it can be a challenge to verify whether the program you created is valid. However, there's a way to programmatically simulate game play! The `ConsoleReadLine()` command accepts input and stores the value to a variable within the program. Once the value is stored, the program can use the value as it continues to execute the script.

Using `ConsoleReadLine()`, modify the program you created to simulate game play. Use `ConsoleReadLine()` to do the following:

- Ask and assign the player's name to the `player` value. Welcome the player and inform them that the game is about to start.
- Confirm whether the player's shot was successful. If the player makes the shot, then increase their score by `1` point. If the player doesn't make the shot, then tell the player to try again.
- Once game is over, print the player's final score to the console.

## Rubric

| Criteria | Exemplary | Adequate | Needs Improvement |
| -------- | --------- | -------- | ----------------- |
|Create game variables.          |All variables are created with proper syntax.           |Most variables are created with proper syntax.           |Incorrect syntax used to create a variable(s).                   |
|Create a method with a `while` loop.          |Method and while loop created using proper syntax.           |Method or `while` loop has a syntax error.          |Method and `while` loop both have improper syntax.                   |
|Use `ConsoleReadLine()` to simulate game play.          |Game simulation outputs accurate strings.           |Game simulation works but produces inaccurate string output.           |Code does not run due to errors.                   |

## Solution

To view a potential solution for this activity, check out the [Solution](/5-c-sharp-foundations/assignment-solution.md).
