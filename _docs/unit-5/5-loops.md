---
title: Loops
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Loops

## Objectives

- Differentiate between the types of loops
- Recall the syntax for each loop type
- Modify the execution of a loop with break or continue

## Introduction

Loops are programming statements that allow for segments of code to be executed repeatedly, as long as a condition is met.

`<image>`

*[Flowchart showing a loop statement]*

There are three different types of loops in C#:

- `while` loop.
- `for` loop.
- `do while` loop.

### While Loop

A **while loop** executes a block of code while a given condition remains true, which is tested before executing the block. The following is the syntax for a `while` loop:

```csharp
while (condition)
{
    //Code to be executed for as long as condition remains true.
}
```

Once the condition is tested and the result is false, the loop's body is skipped and the program will execute what comes after the while loop.

*[Example here]*

### For Loop

Contrary to a while loop, where the number of times its body is executed is not necessarily known, a **for loop** will always know the number of times it has to execute its contents.

That is, `for` loops have a defined number of repetitions.

```csharp
//In C#, a for loop is declared with an initial value, a condition that said value must meet and an increase value by which the initial value is increased every run of the loop.
for ( initial value; condition; increase )
{
    //Code to be executed until condition is met.
}
```
The initial value and increment value are usually numerical, with conditions being commonly established comparing the value that is increasing with a goal value.

```csharp
//This for loop will increase num by 1 until the value assigned to num is equal no longer greater than 10.
for (int num = 1; num < 10; num = num + 1)
{

}
```

### Do ... While Loop

**Do...while loops** are similar to `while` loops, except that the loop will check the condition at the end of the loop, rather than at the start. This ensures that the code block is executed at least one time. The following is the syntax for a `do...while` loop:

```csharp
do 
{
    //Code to be executed
} while (condition);
```
If the condition is true, the loop jump backs to `do` after running, and executes its body again. This process will repeat until the condition is tested and results in false.

### Loop Control

However, there are also statements that allow us to control or change the execution of a loop despite its initial conditions.

In C# we can use:
- `break` which terminates the loop (or switch) statement.
- `continue` which causes the loop to skip part of its body and retest the condition before moving on.

### Infinite Loops

One factor to be aware of is the possibility of loops becoming infinite loops. An **infinite loop** occurs when one of the pre-established conditions never become false. Although this may sound as an error, there are cases where a continuous infinite loop can be used!

Here are two examples:

**infinite while loop**

```csharp
while(true)
{

}
```

Since the condition is not a variable but rather the boolean value of `true`, this `while` loop would never stop running.

**Infinite foor loop**

```csharp
for ( ; ; )
{

}
```

Leaving the conditional expressions of the `for` loop empty leads to the computer assuming them to be true, and will continue executing endlessly.

## Quiz

{% include quiz.html file='unit-5-loops' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD