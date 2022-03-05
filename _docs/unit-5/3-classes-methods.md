---
title: Classes and Methods
---

<link href="//codefence.io/codefence.css" rel="stylesheet">
<script defer type="text/javascript" src="//codefence.io/codefence.js"></script>

# Classes and Methods

## Objectives

- Declare a class and create an object
- Declare a method
- Explain the function of the Main method


## Introduction

There are situations where a program's functionality will ask for solutions that have already been addressed in code. However, rewriting these pieces of code over and over again is not efficient, so C# provides a solution in the form of classes and methods. In C#, a **class** represents a blueprient or skeleton for an object, which in itself encompasses variables, functions, structure and properties.

**Methods** are blocks of code that combine different elements (such as variables) to produce a specific result or carry out a specific function. Methods are declared inside of a class, and as such are dependent on it to be re-used.

### Declaring a Class and Creating an Object

The following is the syntax to create a class:

```csharp
class myClass 
{

}
```

`myClass` is the name given to the class, and anything can be chosen for it. The curly braces `{}` encompass the block of code that pertains to the class.

Inside the block of code, we can create methods and declare variables. We will go deeper into methods in a bit, but these will allow us to add functionality to the program and get or modify information of an instance of the class.

```csharp
class Dog
{
    string name;
    string breed;
    int age;

    public void printHello()
    {
        Console.WriteLine("Hi I'm a dog!");
    }
}
```

To utilize a class, we must create an object of said class. An **object** is an instance of a class, which uses the skeleton or blueprint provided, but is given its own values that identify it as a unique instance.

The following is the syntax to create an object:

```csharp
// We declare objects similar to how we declare variables, using the class name as the 'data type' followed by:
Dog myDog = new Dog();

//To use a method, in this case the printHello():

myDog.printHello();
```

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Dog Class">
<textarea vue-slot="code">

class Dog
{
    string name;
    string breed;
    int age;

    public void printHello()
    {
        Console.WriteLine("Hi I'm a dog!");
    }
}

Dog myDog = new Dog();

myDog.printHello();
</textarea>
</code-fence>

### Declaring Methods

Methods are building blocks, which combine code together to simplify coding. In order to declare a method, there is a specific order of elements.

- An *access identifier*, which determines whether the method can be used by outside code, can be ```public``` or ```private```.
- The *return type*, which depends on the desired outcome of our method. We can return a specific value (by return, programming lingo means resulting in a data value). This will be written as one of the data types we have discussed previously, such as ```int```.
- The *method name* which can be anything, but should aim to make sense with what the method does to make it clearer for anyone who reads the code.
- The *parameters*, which are values or variables that are passed into the method for usage.

The following is an example of a method that adds two numbers and returns the resulting value:

Select **Run** to run the code in the snippet below.

<code-fence lang="cs" heading="Hello World">
<textarea vue-slot="code">
//This defines a public access method that returns an int value, and receives the parameters of type int num1 and num2.

public int addTwo(int num1, int num2)
{
    //
    return num1 + num2;
}
</textarea>
</code-fence>

If you do not need the method to return anything (ex: it's a method that just writes to the console) you can use the return type `void`. This returns nothing and requires no `return` statement.

### The Main Method

There is one particular method that is found in any C# program, which is called the main method. This is where the program starts executing, and executes all the objects and methods, and as such can only be one. 

The main method can be void or int return type, must be declared inside a class and requires a static modifier. 

The following is the syntax to declare a `main` method:

```csharp
class Program
{
    static void Main(string[] args)
    {
        //Here goes the content of the program
    }
}
```

## Quiz

{% include quiz.html file='unit-5-classes-methods' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD