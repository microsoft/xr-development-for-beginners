---
title: Unit Activity
---

# Unit Activity

## Overview

As a hands-on unit, we will be exploring each of the lesson's concepts by creating a sample application. In this case, we will create a pseudo-basketball game.

## Create and Configure a Project

1. Open the Unity Hub and select **Projects**.

    `<image>`

1. Select **New Project**.
1. Select the **3D Core** template from the template list.
1. Choose a name for your project and directory (where the project will be saved).

    `<image>`

1. Select **Create**.

    `<image>`

1. Wait for Unity to fully load the project. Once the project is loaded, navigate to **File > Save As** and save the project.

## Create and Add GameObjects to the Project

Let's now create four new 3D objects for the pseudo-basketball game.

### The Basketball Court

1. In the **Hierarchy** window, right click and select **3D Object > Plane**.
2. Lower the plane to match the scene's plane by changing its `Position` Y value to `-0.5`, or by manually dragging the Y axes using the move tool inside the scene view.
3. Rename the plane to "Court" by right clicking on the Plane object inside the Hierarchy Window. 
4. To change the court's color, create a material by clicking on the `+` sign under the Project View and selecting `Material`. 
5. Rename the material to your liking. 
6. To change the color of the material, select it and change its `Albedo` under the Inspector Window.
7. Drag the material to the plane.

<IMAGES>

### The Character

1. For our character, create a `3D Object > Cube`.
2. Transform the cube's `Scale` by changing its `X` value to `0.69`, `Y` value to `1.7` and `Z` value to `0.6`.

<IMAGE>

3. To make sure the object stands above the plane, change its `Position Y` value to `0.4`. 

### The Ball

1. The ball will be created from a `3D Object > Sphere`.
2. Transform the sphere by adjusting its Scale `X, Y and Z` values to `0.5`.
3. Create a material to change the sphere's color to orange.

<IMAGE>

### The "Hoop"

*The Hoop is a composed object, so it could be easier to use an asset (opportunity to teach how to import them) or another object.*


### The Target Point

The target point represents the point at which our character will aim when throwing the ball, and is represented by an empty object created as a child of the hoop object.

1. Right click on the Hoop object, and select `Create Empty`.
2. Rename the object to TargetPoint.
3. Adjust its transform's Y position to `0.47`.

### The Overhead Point

Similar to the target point, the overhead point is also an empty object. This point will be used to show the ball over the character's head before shooting.

1. Right click on the Character object and select `Create Empty`.
2. Rename the object to OverheadPos.
3. Adjust its transform to sit on top of the character's object. (Change the Y position value to `0.6`).

### The Hold Point

This is yet another empty object used as a position. This will be used to represent the ball being held by the character.

1. Right click on the Character object and select `Create Empty`.
2. Rename the object to HoldPos.
3. Adjust its transform to be in front of the player. (Approximately Y = `-0.4` and Z = `1`).
