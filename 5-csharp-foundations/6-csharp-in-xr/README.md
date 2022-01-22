# C# in XR

*Description of the lesson.*

## Introduction

Although there are multiple languages that can be used in XR development, C# is one of the most commonly used due to its prevalence in the Unity Engine (which is the chosen engine for this curriculum).

### What is C# used for in Unity?

Unity uses C# as its primary language, and although not always necessary to create an XR experience, it provides developers with the opportunity of modifying or altering objects, their behaviors and interactions and more. This is done through pieces of code called *scripts*.

Scripts are custom components that give the developer freedom to play with Unity's elements and expand their designs to a more dedicated level.

Although we will delve deeper into Unity scripting on a later unit, here is an example of a simple script that shows when the application detects input from the mouse:

```csharp
public class testScript
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed the left mouse button!");
        }
    }
}