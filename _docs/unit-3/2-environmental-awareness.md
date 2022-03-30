---
title: Environmental Awareness
---

# Environmental Awareness

## Objectives

- Explain the value of spatial mapping for augmented reality experiences
- Identify use cases for spatial awareness
- Select the appropriate auditory cue(s) for an XR scene

## Introduction

Creating the blend between the physical and digital world is a key characteristic of XR development. The technology leverages concepts such as spatial mapping, spatial awareness, and spatial audio to provide users with a realistic immersive experience. Together, these spatial concepts can truly enhance your XR experience and stay true to providing a seamless blend of the two worlds.

### Spatial Mapping

**Spatial mapping** creates a 3D map of the real-world environment and makes it possible to place 3D objects on real surfaces. More often, a mesh (viewable through the device's lens) is placed onto the real-world environment which is indicative of what the device identifies as a surface. As you move about your physical space, the mesh continuously updates and accounts for changes in your real-world environment.

![A 3D enviroment mesh done through spatial mapping](/assets/img/unit-3/mapping-mesh.jpg)

Once your physical space is mapped, you're able to leverage the mapping for placing 3D objects onto real-world surfaces. Some devices are able to save mapped environments and either load on app start or import into your XR development platform for app creation.
 
### Spatial Awareness

**Spatial awareness** occurs when a 3D object is aware of it's real-world environment. The advantage of spatial awareness is that it provides a natural and familiar form of interaction to the user.

Common usage scenarios for spatial awareness are:

**Placement**

`<image>`

In this scenario, a 3D vase is placed onto a real table. The 3D vase is aware of the table top's surface and snaps to the surface for placement.

**Occlusion**

`<image>`

In this scenario, a 3D chair is only visible when viewed on one side of the wall. **Occlusion** enables you to hide a virtual object. The 3D chair is aware of the wall separating the two rooms.

**Physics**

`<image>`

In this scenario, a 3D ball rolls off the surface of a table and onto the ground before being stopped by the wall. The 3D ball is aware of the objects it interacts with and behaves in an expected manner of rolling.

**Navigation**

`<image>`

In this scenario, a virtual robot navigates around a room, avoiding obstacles. The virtual robot can move around the environment while also being aware of obstacles that obstructs it's path of movement.

### Spatial Audio

We utilize our sense of hearing for communication, to listen and to respond, and also to locate objects around us. Auditory cues can provide a truly immersive experience - essentially mimicking how the user would expect to hear sound in the real world. **Spatial audio** provides this sense of realism by creating sound in 360 degrees around a listener.

There are four auditory cues:

- Ambient
- Object
- Movement
- Instruction

An **ambient auditory cue** is the background noise of an environment. This could be noise in a busy city or the sound of a tv playing off in the distance in another room. An **object auditory cue** is the sound produced from an object. For example, an air conditioning unit produces the sound of a hum when active. A **movement auditory cue** are sounds that are the result of movement. If someone were to run across pavement, we would expect to hear their feet hit the ground. As for an **informational auditory cues**, it's the audio that provides instructions. For example, step-by-step instruction on how to operate machinery.

`<image>`

Placement of the audio plays a major role in how audio is perceived by the user. We can leverage spatial audio features and settings within XR development platforms to fine-tune sound placement and volume.

## Quiz

{% include quiz.html file='unit-3-environmental-awareness' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD