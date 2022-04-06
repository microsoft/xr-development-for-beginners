# Conditional Statements

## Objectives

- Differentiate between the types of conditional statements.
- Recall the syntax for creating a conditional statement.
- Apply conditional statements to decision making in app logic.

## Introduction

There are times where we might want our programs to behave differently depending on the input received. In this case, C# provides the option of preparing in-advance decision making so that after a pre-established condition is met, the program will execute a specific section of code. These statements are referred to as conditional statements.

There are four conditional statements:

- `if` statement
- `if/else` statement
- `else/if` statement
- `switch` statement

Conditional statements can be used in conjunction with the following logical conditions:

- Less than: `a < b`
- Less than or equal to: `a <= b`
- Greater than: `a > b`
- Greater than or equal to: `a >= b`
- Equal to: `a == b`
- Not equal to: `a != 5`

### if statement

The **if** statement is used when we require a specific condition to be met in order for a command to be executed. The code is executed if the condition is `true`.

The following is the syntax to create an `if` statement:

```csharp
if (condition)
{
    //code that runs if condition is true
}
```

Provided below is an example of an if-statement that executes a string if the value `10` is greater than `3`).

```csharp
if (10 > 3)
{
    Console.WriteLine("10 is greater than 3.");
}
```

### if/else statement

An **if/else** statement is used when after a specific condition fails, we want to make sure a specific command is executed.

The following is the syntax to create an `if/else` statement:

```csharp
if(condition)
{
    //code that runs if condition is met
}
else
{
    //code that runs if condition is not met
}
```

Provided below is an example of an if/else statement that evaluates whether `4 x 5` is equal to `30`. Given that `4 x 5` is equal to `20`, the code executes the string within the `else` statement.

```csharp
if(4 x 5 == 30)
{
    Console.WriteLine("The product of 4 x 5 is 30.")
}
else
{
    Console.WriteLine("The product of 4 x 5 is 20.")
}
```

### else/if statement

An **if/else** statement is used when there is a need to test multiple conditions after the first condition fails. An if/else statement executes in the order of `else/if` statements until the final `else` statement executes.

The following is the syntax to create an `else/if` statement:

```csharp
if (first condition)
{
    //code that runs if first condition is met
}
else if (second condition)
{
    //code that runs if second condition is met
}
else if (n condition)
{
    //code that runs if n condition is met
}
else
{
    //code that runs if none of the above conditions are met
}
```

Provided below is an example of an `else/if` statement that evaluates whether a person's `testScore` equates to either an `A`, `B`, `C`, `D`, or `F` letter grade.

```csharp
int testScore = 74;

if (testScore >= 90)
{
    Console.WriteLine("A");
}
else if (testScore >= 80)
{
    Console.WriteLine("B");
}
else if (testScore >= 70)
{
    Console.WriteLine("C");
}
else if (testScore >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}
```

### switch Statement

**switch** acts similar to the previous statement chain, by checking a value rather than a condition against a list of cases. If no matching case is found, then it moves on to execute the default case.

The following is the syntax for a `switch` statement:

```csharp
switch (value)
{
    case case1:
        //code to execute
    [break;]
    case case2:
        //code to execute
    [break;]
    default:
        //code to execute
    [break;]
}
```

Provided below is an example of `switch` statement that outputs the corresponding season for the provided value of `season`.

```csharp
int season = 3;
switch (season)
{
case 1:
    Console.WriteLine("Spring");
    break;
case 2:
    Console.WriteLine("Summer");
    break;
case 3:
    Console.WriteLine("Autumn");
    break;
case 4:
    Console.WriteLine("Winter");
    break;
}
```

## Post-Lecture Quiz

[Quiz](https://ashy-plant-023e6671e.1.azurestaticapps.net/quiz/14)

## Review and Self Study

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [C# Conditions](https://www.w3schools.com/cs/cs_conditions.php)