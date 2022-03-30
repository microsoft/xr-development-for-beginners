---
title: Variables and Data Types
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Variables and Data Types

## Objectives

- Declare a variable
- Select the appropriate data type for a variable
- Recognize the function of the assignment operator

## Introduction

Programming languages make use of the computer's memory to 'remember' previous information to be used throughout a program's execution, such as specific values, names and inputs. These are stored in allocations of the computer's memory called **variables**.

![Three buckets of different sizes, with the words integer, string and double printed on them](/assets/img/unit-5/variable-buckets.png)

Variables work like a bucket, where once it has been declared (created in programming terms) we can put, retrieve or modify the things in it. However as with a real bucket, its size is important depending on the contents we intend to put in, so variables come in different sizes depending on the type of data we want to store. These data types have their own label and help us declare the appropriate size variable for our uses.

### Declaring a variable

**Declaring** a variable in C# means to tell the computer to allocate space in its memory large enough to hold the specific type of data by the label. The way this is done is by first writing the label (or type of data) that the variable will store, followed by the name we wish to give to the variable.

Here we declare two variables to store numbers:

<code-fence lang="cs" heading="Declare Variables">
<textarea vue-slot="code">
int x;
int y;
</textarea>
</code-fence>

At this time, these variables are just two empty spaces. We can assign (store) values to this allocated space in memory using the `=` sign. In C# and most programming languages, the equal sign is known as the assignment operator. This means it does not work the same way it works in regular math, and what it does is store a value inside a variable.

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Assign Value to Variables">
<textarea vue-slot="code">
//Storing the number 4 in variable x
int x = 4;

//We can also store a value resulting from a mathematical operation, let's try storing the value of x + 2 in y
int y = x + 2;

Console.WriteLine(y);
</textarea>
</code-fence>

What our program is doing here is storing the number 4 in our variable `x`, and storing the value of `x + 2 (4+2)` in our variable `y`.

Once the variables have been declared, the data type label is no longer necessary.

### Common Data Types in C#

However, we may not always want to deal with numbers. In fact, we have just touched upon integer numbers (that is, no decimals). C# has other variable types that we can use, depending on what we need our program to do. 

The following list shows the most common data types in C#, and how to declare them.

<code-fence lang="cs" heading="Common Data Types in C#">
<textarea vue-slot="code">
int var = 10;
double dvar = 2.78;
bool bvar = true;
char cvar = 'M';
string svar = "Hello World";
</textarea>
</code-fence>

- The first variable is the type we declared previously, **Integer**. This data type is used when working with whole numbers.
- The second variable is another number related type, **Double**. This is used for numbers that contain decimal values, such as rational numbers.
- The third variable is called a boolean variable, **Bool**. Bool holds one of two possible values: *True* or *False*, and it's used as a condition marker.
- The fourth variable holds a single character, such as a number, a letter or a symbol. It's called **Char**.
- The last variable is called a **String Literal**. This data type is used to store words or sentences.

## Quiz

{% include quiz.html file='unit-5-variables-data-types' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [C# Data Types and Variables - Software Testing Help](https://www.softwaretestinghelp.com/c-sharp/csharp-data-types-and-variables/#:~:text=C%23%20Data%20Type%20%20%20%20Type%20,%20%20False%20%209%20more%20rows%20)
- TBD
- TBD