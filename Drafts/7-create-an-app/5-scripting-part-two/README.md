# Scripting - Part 2

*Description of the lesson.*

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Prerequisites


## Introduction

The next step is to let our character pick up the ball and throw it. For this we will need to establish certain conditions and define the logic of the game before writing the script.

## Flowchart

A good tool to help us define the logic we wish our script to follow is to develop a flowchart of the events that will happen in the app.

A flowchart for the basketball game could look as follows:

<IMAGE>

With this in mind, we can move on to start adding the remaining functionality to our script. From last lesson's progress, the script should look like this:

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
        //Creating a direction vector based on the input axes.
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //Change the position transform by the direction vector times the defined movement speed and the time.
        transform.position += direction * MoveSpeed * Time.deltaTime;
        //Make the character look towards the vector's direction.
        transform.LookAt(transform.position + direction);
    }
}

```

## Activity: Adding the Hold functionality.


1. Right above our MoveSpeed float variable, we will define three Transform objects, one for Ball, one for OverheadPos and one for TargetPoint.

```csharp
    //Objects
    public Transform Ball;
    public Transform OverheadPos;
    public Transform Target;
    //Variables
    public float MoveSpeed = 5;
```
2. The next step is to define two boolean (true/false value) variables to define whether the ball is in the character's hands or if it's flying. We will also define a variable of type float for time and assign it the value 0.

```csharp
    //Variables
    public float MoveSpeed = 5;
    //Our game will start with the ball in the character's hand, thus the assigned value is true.
    private bool BallInHands = true;
    private bool isBallFlying = false;
    private float T = 0;
```

3. Now we add the first conditional, based on whether the ball is being held by the character or not. This is done inside the `Update` method under the movement section.

```csharp
//Shooting Section

 //First conditional, whether the ball is in the character hands.
        if (BallInHands)
        {
            //If it is, we will define the space key as the key to hold the ball over the character's head.
            if (Input.KeyCode.Space))
            {
                //Once the space key is pressed, change the ball's position to the Overhead position.
                Ball.position = OverheadPos.position;
                //And make the character look at the target point (as if it is aiming)
                transform.LookAt(Target.parent.position);
            }
            //If the space key is not pressed, the ball is held at the HoldPos point.
            else
            {
                Ball.position = HoldPos.position;
            }
        }
```

## Activity: Adding the Shoot Functionality.

For the ball to be thrown, we will define that the character must first hold it over their head before shooting. 

1. With this in mind, we will add a conditional to shoot once the space key (which was being pressed to hold the ball previously) is lifted. We can add this below the `else` statement.

```csharp
    //If the Space key is lifted
    if (Input.GetKeyUp(KeyCode.Space))
    {
        //For the ball to be shot, it must leave the character hands, so we make the boolean variable false.
        BallInHands = false;
        //To begin shooting, we change the boolean flying to true (as the ball starts flying from the hands)
        isBallFlying = true;
        //And restart the time (so that the new series of events can be easily written)
        T = 0;
    }
```
2. The next step is to add what will happen once the ball is shot. The general idea for this is as follows:
- Create two vector points, one for the **Target Point**, one for the **Overhead Position**.
- Create a new vector by linearly interpolating the two other vectors.
- Change the ball position through that last vector.

```csharp
    if(isBallFlying)
    {
        //Time variable is assigned a new value based on the time the event starts
        T += Time.deltaTime;
        //duration of travel
        float duration = 0.5f;
        //This variable allows for the interpolation to be accurate, as we want a set duration for the shooting.
        float t01 = T / duration;

        Vector3 point_A = OverheadPos.position;
        Vector3 point_B = Target.position;
        //Lerp is the linear interpolation function, will result in a new vector that will represent the trajectory from A to B.
        Vector3 pos = Vector3.Lerp(point_A, point_B, t01);

    }
```

> Note: If we were to simply change the Ball's position to the `pos` vector, the ball would move in a straight line, a bit unrealistic.

3. To move the ball in a realistic way, we can create an arc and add it to the ball's position after being shot. Feel free to copy paste this section of the code.

```csharp  
        //Arc created using sine function
        Vector3 arc = Vector3.up * 5 * Mathf.Sin(t01 * 3.14f);
        //Moves the ball in an arc function 
        Ball.position = pos + arc;
```
4. If you run the Game View as it is, the ball will move properly, but will remain stuck at the hoop. As such, we need to activate physics on it so that gravity affects it.

> In Unity, click on the Ball object, and under the inspector window click on `Add Component`. Select `Rigidbody`, and make sure to check the `isKinematic` checkbox.

5. Once this is done we can manipulate the rigidbody component via script.

```csharp
    //If t01 is greater than one (the event of shooting has occurred), we change the isBallFlying boolean value to false (no longer flying) and the Rigidbody component's isKinematic value to false so that it falls.
    if (t01 >= 1)
    {
        isBallFlying = false;
        Ball.GetComponent<Rigidbody>().isKinematic = false;
    }

```

## Activity: Picking up the Ball

In order to pick up the ball once it has been shot, we must a new component for our Character, called a `Capsule Collider`. This will allow us to detect when the Character is close to the ball and move it back to the hold position.

1. Click on the `Character` Object.
2. Under the inspector window, click `Add Component` and select `Capsule Collider`.
3. Edit its radius and height, approximately `0.8` for radius and `1.2` for height.
4. Check on the `isTrigger` checkbox.
5. Add the following method *outside* of the `update` method in our script:

```csharp
    //when the collision trigger happens, this method is executed.
    private void OnTriggerEnter(Collider other)
    {
        //Conditional: If the ball isn't flying or has not been picked up yet, pick up the ball and activate its Rigidbody component's kinematics.
        if (!BallInHands && !isBallFlying)
        {
            BallInHands = true;
            Ball.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
```

## Conclusion

The application should be able to compile and work with each of the functionalities we added. If needed, the full script script can be found [here](./basketballGame.cs).

The application can be further improved, moving/editing the camera angle; providing new materials for the Character model, or importing assets. 