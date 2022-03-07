# Creating Game Objects
*Description of the lesson.*

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Prerequisites


## Introduction

Once the project has been created and its settings adjusted to meet the application's needs, we are faced with an empty scene with just a main camera and directional light.

These can be interacted with by moving, rotating them, etc. But we will get into this later.

## Populating a Scene

In order to add new objects to our scene, we can either click the `+` sign under our Hierarchy window, or by right clicking inside the window itself.

*screenshot of + sign and right click options*
<IMAGE>

*Note: Could go over the types of objects, but it might be too much information*

## Transforming Objects

Unity allows us to interact with Game Objects in multiple ways, the main one being through the Transform component. Every object has a Transform, which determines its position, rotation and scale with respect to the scene. 

**Properties**

|Property  |Function |
|---------|---------|
|`Position`     |   Determines the position of the Transform in X, Y, Z coordinates. If modified, the object will be moved as its position is changing.      |
|`Rotation`    |  Rotation of the Transform around the X, Y and Z axes. It is measured in degrees.       |
|`Scale`     |  TScale of the Transform along X, Y, and Z axes. Value "1" is the original size, and by changing it the object will change its size.       |

All three of the Transform's properties can be changed via text input on the inspector window, or by utilizing the appropriate tool inside the scene view.

## Changing an Object's Appearance

In Unity, materials and shaders define the appearance of objects in a scene. A material contains a reference to a Shader object. If that Shader object defines material properties, then the material can also contain data such as colors or references to textures.

Materials are considered assets which can be re-used in multiple objects, and can be created inside the Project View by selecting `Assets > Create > Material`, as well as imported from outside sources.

These materials can be modified inside the Inspector window, and can equally be assigned to an object via the inspector window or by dragging the material asset directly to the game object.

*screenshot of inspector window and screenshot of dragging*
<IMAGE>

## Activity: Creating the objects for our sample app

We will begin this unit's activity by creating four new 3D objects for our pseudo-basketball game.

### The Court

1. First our court: Click on the `+` sign under the Hierarchy Window and select `3D Object > Plane`.
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