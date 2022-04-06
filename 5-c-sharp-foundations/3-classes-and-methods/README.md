# Classes and Methods

## Objectives

- Declare a class and create an object.
- Declare a method.
- Explain the function of the Main method.

## Introduction

There are situations where a program's functionality will ask for solutions that have already been addressed in code. However, rewriting these pieces of code over and over again is not efficient, so C# provides a solution in the form of classes and methods. In C#, a **class** represents a blueprint or skeleton for an object, which in itself encompasses variables, functions, structure and properties.

**Methods** are blocks of code that combine different elements (such as variables) to produce a specific result or carry out a specific function. Methods are declared inside of a class, and as such are dependent on it to be re-used.

### Declaring a Class and Creating an Object

The following is the syntax to create a class:

```csharp
class MyClass
{

}
```

`MyClass` is the name given to the class, and anything can be chosen for it. The curly braces `{}` encompass the block of code that pertains to the class.

Inside the block of code, we can create methods and declare variables. We will go deeper into methods in a bit, but these will allow us to add functionality to the program and get or modify information of an instance of the class.

```csharp
class Dog
{
    public string name;
    public string breed = "Great Dane";
}
```

Each instance (or **object**) of the class uses the skeleton or blueprint provided, but is given its own values that identify it as a unique instance. In the `Dog` class above, we've assigned two attributes. The first is a string for the dog's `name` and the second is a string for the dog's `breed`. Essentially, each instance of the `Dog` class will have a different `name`. However, the `breed` for each instance will always be a `Great Dane`.

Now that the `Dog` class is created, you can create an object of the class and use the object wherever necessary in your program.

The following is the syntax to create an object.

```csharp
// We declare objects similar to how we declare variables, using the class name as the 'data type' followed by:
class Dog
{
    public string name;
    public string breed = "Great Dane";
}

Dog myDog = new Dog();
myDog.name = "Baxter";

Console.WriteLine(myDog.name);
Console.WriteLine(myDog.breed);
```

### Declaring Methods

Methods are building blocks, which combine code together to simplify coding. Methods are only run when they are called.

The following is the syntax to create a method:

```csharp
static void MyMethod ()
{
    // code to be executed
}
```

In order to declare a method, there is a specific order of elements.

- An *access identifier*, which determines whether the method can be used by outside code, can be `public` or `private`.
- The *return type*, which depends on the desired outcome of our method. We can return a specific value (by return, programming lingo means resulting in a data value). This will be written as one of the data types we have discussed previously, such as `int`.
- The *method name* which can be anything, but should aim to make sense with what the method does to make it clearer for anyone who reads the code.
- The *parameters*, which are values or variables that are passed into the method for usage.

The following is the syntax to call a method:

```csharp
MyMethod();
```

The follow is an example of a method that outputs the string `Hello World`.

```csharp
static void HelloWorld()
{
Console.WriteLine("Hello World");
}
HelloWorld();
```

If you don't need the method to return anything (ex: a method that just writes to the console) you can use the return type `void`. This returns nothing and requires no `return` statement.

The following is an example of a method that adds two numbers and returns the resulting value.

```csharp
//This defines a public access method that returns an int value, and receives the parameters of type int num1 and num2.

public int addTwo(int num1, int num2)
{
    //
    return num1 + num2;
}
```

### The Main Method

The `Main` method is used across all C# programs. This is where the program begins executing all of a program's objects and methods. A program can contain only one `Main` method.

The `Main` method either be a `void` or `int` return type and must be declared inside a class. In addition,the `Main` method requires a static modifier.

The following is the syntax to declare a `Main` method:

```csharp
class Program
{
    static void Main(string[] args)
    {
        //Here goes the content of the program
    }
}
```

## Post-Lecture Quiz

[Quiz](https://ashy-plant-023e6671e.1.azurestaticapps.net/quiz/13)

## Review and Self Study

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [C# Methods](https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/methods)
- [C# Object and Collection Initializers](https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)
