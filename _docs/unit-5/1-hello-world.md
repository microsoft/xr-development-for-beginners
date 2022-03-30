---
title: Hello World
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Hello World

## Objectives

- Differentiate between input and output
- Identify reasons for an error
- Create comments in a script

## Introduction

Albeit not as crucial to XR as it may be to other areas of technology, coding is still an important part of the process to create XR experiences. The C# programming language is used in our chosen engine, Unity, to create scripts that control actions and properties of objects inside the application, as well as giving us a deeper understanding "inside the hood" of the project.

### Understanding Input and Output

Input and Output represent the most basic concepts of programming, as computers receive instructions (**input**) and programs execute them to produce a result (**output**). Though the format in which these instructions are received may vary, the general concept remains the same. In C#, basic output is shown through the **console window**. 

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Hello World">
<textarea vue-slot="code">
Console.WriteLine("Hello World");
</textarea>
</code-fence>

What this snippet does is instruct (input) the computer to *print* the message inside the parenthesis as a new line in the console window (output).

There is no need to delve much deeper than that, but it would be useful to keep track of patterns (like the semicolon at the end of the line), as these will come into play later.

### Errors

Errors are bound to happen while writing code, and this is a non-avoidable fact. Thankfully, these are bound to be solvable as well. Early on, the most common errors will have to deal with **syntax** which are the rules, keywords and operators that dictate how the language is written.

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Error">
<textarea vue-slot="code">
console.WriteLine("Hello World");
</textarea>
</code-fence>

This code produces an error given that `console` is not defined. This happens due to the fact that C# is case sensitive. The case (lowercase or uppercase) of the letter **C** is different and therefore considers `console` and `Console` to be different.

Some common errors to avoid early on:

- Mixing lower-case letters instead of capitalizing when needed.
- Writing a comma instead of a period between `Console` and `WriteLine`
- Adding spaces outside of quotation marks.
- Forgetting double quotation marks (at the beginning and at the end) of a string.
- Forgetting the semi-colon (;) at the end of a command

### Comments

When writing code in C#, any instruction prefaced by `//` is ignored by the computer, does not output in the console window, and is considered a code comment. These come in handy when testing new ways of writing code, as it allows for older pieces of code to remain in our program without needing to delete them.

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Comments">
<textarea vue-slot="code">
// The command below prints the string Hello World.
Console.WriteLine("Hello World");
</textarea>
</code-fence>

Moreover, these are particularly useful to leave notes to ourselves or others who might read our code in the future. Though the syntax might be the same, the way code is written can vary from person to person, so explaining our thought process or what a certain piece of code is doing is always recommended as a good practice.

## Quiz

{% include quiz.html file='unit-5-hello-world' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [Take your first steps with C# - Microsoft Learn](https://docs.microsoft.com/en-us/learn/paths/csharp-first-steps/)
- [Hello World in C# - Geeks for Geeks](https://www.geeksforgeeks.org/hello-world-in-c-sharp/)