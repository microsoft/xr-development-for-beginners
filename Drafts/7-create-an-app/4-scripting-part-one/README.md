# Scripting - Part 1
*Description of the lesson.*

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Prerequisites


## Introduction

After creating the app's Game Objects, the next step is to add functionality. This is done through the use of a script that tells the objects what to do depending on the user's input.

## Activity: Creating a Script that allows the player to move.

The first step for our pseduo-basketball game to work is to ensure the player character is able to move. To achieve this, we will create a script that uses the keyboard's input (in this case the arrow keys) to move the character object around.

1. First, create the script under `Assets` in the Project View. This can be done by clicking the `+` and selecting `C# Script` or by right clicking in the Assets folder and selecting `Create > C# Script`.
2. The script can be seen under the Inspector Window by clicking on it, however in order to edit it we can double click it; which in turn will open Visual Studio.
3. Once in Visual Studio, the script should look like this:

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

4. We can go ahead and erase the following method:
```csharp 
void Start()
``` 

5. Create a new public variable of type float called `MoveSpeed` and give it a value of 5. This will determine how fast the character moves.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballGame : MonoBehaviour
{
    public float MoveSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        
    }
}
```


6. Using a class named `Vector3` we will create a direction vector object that is defined by the Horizontal and Vertical axes provided by the input keys. This will be done inside the `Update` method.

```csharp
void Update()
{
//Creating a direction vector based on the input axes (X being Horizontal direction, Y being 0 as we do not want the player to move beyond the plane and Z being Vertical direction).
    Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
//Change the position transform by the direction vector times the preset movement speed and the time.
    transform.position += direction * MoveSpeed * Time.deltaTime;
//Makes the character look towards the vector's direction.
    transform.LookAt(transform.position + direction);
}

```
7. Save the script.
8. In Unity, drag the script from the Asset Window to the Character object.
9. Enter the Game View by pressing the play button. Your character should be able to move following your arrow keys input.


