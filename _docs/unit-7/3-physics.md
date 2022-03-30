---
title: Physics
---

# Physics

## Objectives

- To become familiar with Rigidbody components, their behavior and capabilities as gateways for GameObject physics.
- Understand the concept of colliders and how these allow for interaction between GameObjects.
- Become aware of the possibility of collisions, as well as how these can be detected and managed.

## Introduction

Adding physics to a GameObject enables such objects to interact and collide with other objects we'd expect them to in the real world. With Unity's physics engine, you can simulate physics for GameObjects and configure in such a way that mimics real-world expectations.

### Rigidbodies

A **Rigidbody** is a GameObject component that serves as the gateway to enabling physics for a GameObject. A key difference between a Rigidbody and the Transform component is that a Rigidbody can receive forces and torque whereas a Transform cannot. When a GameObject with a Rigidbody collides with another object, the GameObject's position and rotation of the Transform changes. Therefore, you shouldn't manipulate both a GameObject's Rigidbody and Transform. Doing so could lead to problems with collisions.

### Colliders

GameObjects that contain a Rigidbody must be accompanied by a collider. A **collider** is an invisible layer surrounding a GameObject that defines it's shape. The Rigidbody and Collider components work together for the purpose of physical collisions. It defines the point of entry for a collision between two GameObjects.

![Screenshot depicting a capsule collider around a character model](/assets/img/unit-7/colliders.jpg)

Colliders are a rough approximation of the shape of a GameObject - thus, the shape does not need to be perfect.

Unity provides primitive colliders that can be resized across a GameObject. These colliders are:

- Box Collider
- Sphere Collider
- Capsule Collider

If using a primitive collider, consider using one that best reflects the shape of the GameObject. For example, a Box Collider would be best suited for a cup GameObject. 

You could also add multiple colliders to a GameObject to account for complex shapes.

![Screenshot of a series of colliders used to map a complex shape](/assets/img/unit-7/complex-collider.jpg)

### Collisions

A **collision** is when two GameObjects hit (or collide) with one another. You can use code to detect when collisions occurs and initiate actions using the `OnCollisionEnter` function. The physics engine can also detect when one collider enters the space of another without creating a collision.

![An animated image of three balls colliding with a set of cubes](/assets/img/unit-7/unity-collision.gif)

GameObjects must have a Collider component to be considered collidable. When adding a Collider to a GameObject, ensure that all areas of the GameObject are contained within the Collider. If a portion of a GameObject is not contained within the Collider, any GameObject that touches the non-collider contained part of the GameObject is not considered to be a collision.

## Quiz

{% include quiz.html file='unit-7-physics' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [RigidBody - Unity Documentation](https://docs.unity3d.com/Manual/class-Rigidbody.html)
- [Colliders - Unity Documentation](https://docs.unity3d.com/Manual/CollidersOverview.html)
- [Understanding Collisions](https://www.tutorialspoint.com/unity/unity_understanding_collisions.htm)