---
title: Physics
---

# Physics

## Objectives

- Explain the relationship between forces and pivots
- Identify how force can be applied to an object
- Predict the direction of movement whether a pivot point is provided

## Introduction

In XR, physics play an important role in making the experience as close to the real world as possible. Physics enables objects to be controlled and manipulated by approximating some of the forces in the real world, like gravity. Moreover, certain engines provide the opportunity to give objects values such as mass that allow further physical interactions between them and the environment.

### Gravity

If you were to hold an object in the air and let go, you'd expect the object to fall thanks to gravity. Gravity is a force that attracts either a body or object toward the center of the earth, or toward any other physical body or object having mass. In XR, we can simulate the act of gravity by adding gravity to virtual objects. Each XR platform has it's own method to apply gravity to 3D objects and thus the method in doing so varies. While adding gravity to virtual objects is not a requirement, doing so does provide a sense of realism. Given that XR has the capability to blend the digital and physical world in such a way that provides a seamless experience, consider striving for adding gravity to objects wherever appropriate.

![A sphere having multiple objects attracted to its surface due to gravity](/assets/img/unit-2/unity-gravity-system.gif)

### Forces

Any interaction that modifies or changes the motion of an object is considered a **force**. When a force is applied to an object, it's movement, direction and/or speed are altered. Forces have their own magnitude and direction, which means they can be represented as vectors. Though vectors are mathematical concepts with their own operations and rules, we do not need to go in depth for a basic understanding and usage in XR development.

![An image of a vector with its different properties](/assets/img/unit-2/vector.png)

Forces can be applied through environment changes, user's input, etc. As an example, applying force in the right direction to an object as the user presses a button, can move the object in that direction provided no other forces are currently acting on its body.

![An object moving from one side to another due to forces](/assets/img/unit-2/movement.gif)

### Pivots

Nonetheless, certain movements (like rotations) require more than just force to occur. This is where the concept of a pivot comes to play. A **pivot** is a (usually central) point, on which an object oscillates or turns. In XR development, a pivot point is an element that is added to objects in order to mimic turning, rotation or oscillation when a force is applied.

![Two cubes rotating around a pivot point](/assets/img/unit-2/pivot-unity.gif)

Without a pivot point, any force added to an object will result in movement (provided the applied force is greater than any other existing force already acting on the object, like gravity) in the direction of the force. After adding a pivot point however, the application of force may result in turning or oscillation, depending again on the existing forces *and* the direction of the applied force.

## Quiz

{% include quiz.html file='unit-2-physics' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD