# Making Decisions

*Description of the lesson.*

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Prerequisites

## Introduction

There are times where we might want our programs to behave differently depending on the input received. In this cases, C# provides the option of preparing in-advance decision making so that after a pre-established condition is met, the program will execute a specific section of code.

>For example, if we are developing a VR basketball game, you want to make sure that points are counted based on where the ball was shot from, so that 3-pointers are included.

There are four main decision making statements:

- If statement.
- If/else statement.
- If/else if/else statement.
- Switch case statement.

### If statement

The if statement is used when we require a specific condition to be met in order for a command to be executed. The statement is written as follows:
```csharp
if (condition)
{
    //code that runs if condition is true
}
```
*[Example using the basketball analogy]*


### If/else statement

This statement is used when after a specific condition fails, we want to make sure a specific command will be executed. This command is written under the else statement, and it looks as follows:

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

This decision statement is used when there is a need to test multiple conditions after the first condition fails. It executes in order until the else statement (where every other condition has failed). 

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

Switch acts similar to the previous statement chain, by checking a value rather than a condition against a list of cases. If no matching case is found, then it moves on to execute the default case.

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

## Pre-Lecture Quiz Questions & Answers

*NOTE: Use markdown to make the correct answer bold (ex: `**This is the syntax for marking the answer in bold.**`)*

**Question 1**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 2**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 3**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 4**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 5**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

## Post-Lecture Quiz Questions & Answers

**Question 1**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 2**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 3**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 4**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 5**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*