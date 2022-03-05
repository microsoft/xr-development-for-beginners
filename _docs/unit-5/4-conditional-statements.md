---
title: Conditional Statements
---

# Conditional Statements

- Differentiate between the types of conditional statements
- Recall the syntax for creating a conditional statement
- Apply conditional statements to decision making in app logic

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Introduction

There are times where we might want our programs to behave differently depending on the input received. In this case, C# provides the option of preparing in-advance decision making so that after a pre-established condition is met, the program will execute a specific section of code.

For example, if you're developing a VR basketball game, you'd want to make sure that points are counted based on where the ball was shot from, so that 3-pointers are included.

There are four main conditional statements:

- `If` statement.
- `If/else` statement.
- `If/else if/else` statement.
- `Switch` case statement.

### If statement

The **if statement** is used when we require a specific condition to be met in order for a command to be executed. The following is the syntax for an `if` statement.

```csharp
if (condition)
{
    //code that runs if condition is true
}
```

*[Example using the basketball analogy]*


### If/else statement

An **If/else** statement is used when after a specific condition fails, we want to make sure a specific command is executed. This command is written under the else statement, and the syntax is as follows:

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

*[Example using the basketball analogy]*

### If/else if/else statement

An **If/else if/else statement** is used when there is a need to test multiple conditions after the first condition fails. It executes in order until the `else` statement (where every other condition has failed). The following is an example of such syntax:

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

*[Example with new analogy or continuing the previous analogy]*

### Switch case statement

**Switch** acts similar to the previous statement chain, by checking a value rather than a condition against a list of cases. If no matching case is found, then it moves on to execute the default case. The following is the syntax for a `switch` statement:

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

*[Example with new analogy or continuing the previous analogy]*

## Quiz

{% include quiz.html file='unit-5-conditional-statements' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD