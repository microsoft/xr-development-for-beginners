---
title: Comfort
---

# Comfort

## Objectives

- Explain the relationship between vergence and accommodation
- Recognize the visual impact of utilizing illegible text and improper object placement distance
- Identify use cases for virtual motion as an alternative to physical movement

## Introduction

Comfort encompasses the multiple human perception-related factors that must be accounted for when developing a reality-altering application. In normal circumstances, humans perceive their surroundings through multiple sources of information, gathered from each of the five senses. To ensure a smooth user experience, XR applications must aim to present their content in ways that mimic the way real world information is presented.

For example, a worker wearing a head mounted device to control or oversee a piece of machinery must be able to process the information given to them in real time, in a manner that is comfortable to their eyes. If their eyes are forced to focus in an unnatural way, it may lead to fatigue and possible danger.

![A worker oversees a piece of machinery with a digital model in extended reality through a headset](/assets/img/unit-2/worker-machinery.jpg)

Moreover, depending on the level of immersion, the user's physical space must also be taken into consideration  so that the content does not require dangerous or fatiguing motions. Users should be able to experience the applications without discomfort or danger to themselves and their surroundings.

Understanding some of these factors will help ensure the comfort of XR users:

- Vergence and Accommodation
- Text Legibility
- Self-motion and User Locomotion
- Gaze Direction
- Arm Positions

### Vergence and Accommodation

To view objects clearly, human eyes rotate and adjust their focus to the distance of an object. **Vergence** is the movement of both eyes to maintain single binocular vision (avoiding seeing double images). **Accommodation** is the process by which human eyes maintain a clear image or focus on an object despite changes in distance. In a natural setting, these two concepts are linked.

For example, if we bring a finger close to our nose and try to focus on it, our eyes will cross and accommodate to it. If we try to see something far, our eyes lines of sight become parallel and our lenses accommodate to focus.

However, on a head-mounted display or an immersive device, users accommodate to the focal distance of the display to focus on an image, but will converge to the distance of the object to get a single image. This breaks the previously mentioned link, as the eyes are accommodating and converging to different distances, creating visual discomfort and fatigue.

These issues can be addressed by:

- Placing objects within an optimal viewing zone: between 1.25m and 5m from the user.
- Reducing the amount of time users must be focused on content that is near (budget for no more of 25% of the time spent on the app looking at closer objects).
- Minimize how often users must change focus between near and far digital objects.

### Text Legibility

Ensuring that text is easily legible can help reduce eye strain and fatigue. Legibility depends on factors such as:

- Text and font properties, such as background color, weight, spacing and serifs.
- Display properties, such as pixel density, brightness and contrast.
- Lens properties.

Font sizes should be made as large as possible to ensure a comfortable experience, while keeping an eye on possible background contrast.

`<image>`

In an application designed for outdoors usage, daylight should be taken into account as a factor when choosing the text's font, color and background color. Light colors might work at night-time, but may become harder to read during the day. The same applies for darker colors on the opposite scenario.

`<image>`

### Self-Motion and User Locomotion

How the user experiences the application in their physical space must be addressed from the design stage. Certain limitations must be put in place from the start, such as the desired range of movement and how it may affect the application given a different size of physical space.

If the user is expected to move further than their physical space allows, virtual motion must be implemented. Virtual motion encompasses methods of movement inside the XR experience that do not require any kind of physical movement to be carried out. Instead, the user may use the controller's joystick to navigate the virtual environment. Alternatively, the user may use **teleportation** which enables them to immediately jump longer distances.

![A virtual reality app showcasing teleportation by marking the end location with a controller](/assets/img/unit-2/vr-teleportation.JPG)

When utilizing virtual motion, it is important to note the possibility of motion sickness. This will most likely occur when the virtual motion is unexpected, continuous or does not match the user's real physical motion.

In order to avoid these issues, user movement should be implemented taking these factors into account:

- Always give the user control of their movement.
- Avoid vertical motions, especially non-user initiated ones, as humans are sensitive to the direction of gravity.

### Gaze Direction

Ensuring that excessive eye and neck movement is avoided can help reduce fatigue as well as eye and neck strain. Avoiding angles more than 10 degrees above the horizon, 60 degrees below the horizon and neck rotations more than 45 degrees off-center can help in reducing unnecessary eye and neck movements.

![A person wearing a headset displaying the different angles of vision](/assets/img/unit-2/gaze-direction.png)

Take into account that there is an optimal resting gaze angle at 10-20 degrees below the horizon as well.

### Arm Positions

A factor of comfort that can be easily overlooked is the expectations of a user's physical position. Repeatedly requesting the user's gesture input or forcing the user to keep their arms in an unnatural manner for long periods of time (such as keeping their hand raised) can rapidly become an issue and cause muscle fatigue. 

![A person holding controllers with their arms raised](/assets/img/unit-2/arm-positioning.png)

Adding short breaks between inputs and mixing others forms of input (such as speech) can reduce muscle strain and make the experience smoother.

## Quiz

{% include quiz.html file='unit-2-comfort' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD