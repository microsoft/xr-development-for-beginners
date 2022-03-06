---
title: Unit Activity
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Unit Activity

## Instructions

In this activity, you'll use C# to create basic app logic for the basketball game. Each exercise reflects logic that could be used in a script for game play.

1. Create a `player` variable for the app's player.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.




    </textarea>
    </code-fence>

1. The `player` must have possession of the basketball to take a shot. If the `player` does not have the basketball, then they must wait to take another shot. When the game starts, the `player` has possession of the basketball up until they shoot the basketball. Create a conditional statement that reflects what happens if the `player` does not have the basketball in their possession.

1. Create a `player` variable for the app's player.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.




    </textarea>
    </code-fence>

1. Create a `score` variable for the total number of points received from a successful basketball shot.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.




    </textarea>
    </code-fence>

1. When the game starts, the `score` is set to `0`. Each time the `player` makes a successful shot, their `score` increases by `1` point. Create a `TakeShot` method that increments the player's `score` by `1` point if their shot is successful.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.




    </textarea>
    </code-fence>

1. The `player` has `5` chances to make a shot. After their 5th shot, the game is over. Create a while loop that executes the `TakeShot` method until the `player` has taken their 5th shot.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.




    </textarea>
    </code-fence>

1. When the game is over, the total `score` is output for the `player`. Use the `Console.WriteLog()` command to create a string that outputs the player's `score`.

    <code-fence lang="cs" heading="Try It">
    <textarea vue-slot="code">
    // You can type directly into this code block
    // Click Run to execute the program.
    
    
    
    
    </textarea>
    </code-fence>

## Bonus

Without a game in play, it can be a challenge to verify whether the program you created is valid. However, there's a way to programmatically simulate game play! The `ConsoleReadLine()` command accepts input and stores the value to a variable within the program. Once the value is stored, the program can use the value as it continues to execute the script.

<code-fence lang="cs" heading="ConsoleReadLine() Example">
<textarea vue-slot="code">
// Click Run to execute the program.

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

</textarea>
</code-fence>

Using `ConsoleReadLine()`, modify the program you created to simulate game play. Use `ConsoleReadLine()` to do the following:

- Ask and assign the player's name to the `player` value.
- Check whether the `player` has the ball.
- Confirm whether the player's shot was successful.

With `ConsoleReadLine()`, you can simulate an entire round of the basketball game by inputting responses that'll in return execute your program's `TakeShot` method.

<code-fence lang="cs" heading="Try It">
<textarea vue-slot="code">
// You can type directly into this code block
// Click Run to execute the program.

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

</textarea>
</code-fence>

## Solution

To view a potential solution for this activity, check out the [Unit Activity Solution](link).