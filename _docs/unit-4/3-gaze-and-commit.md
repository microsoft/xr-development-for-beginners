---
title: Gaze and Commit
---

# Gaze and Commit

## Objectives

- Summarize the gaze and commit modalities
- Evaluate object placement to avoid gaze discomfort
- Choose a modality best suited for an XR app or experience

## Introduction

The Gaze and Commit model is a fundamental model that is closely related to the way we interact with our computers using the mouse: Point & click. A user targets an object or UI element and then interacts or clicks on it using a secondary input. Gaze and Commit is considered a far input model with direct manipulation. It's best used for interacting with virtual objects or content that is out of reach.

There are two modalities for the gaze and commit input model:

- Eye-Gaze and Commit
- Head-Gaze and Commit

### Eye-Gaze and Commit

Eye-gaze and commit is an input model that involves targeting an object by looking at it and then acting on the target with a secondary commit input (ex: hand gesture, voice command, or peripheral input like a game controller). Our eyes move incredibly fast and are great at quickly targeting across the view. Eye-gaze is ideal for quick gaze-and-commit actions especially when combined with fast commits such as a button press.

![A person wearing a headset selecting different objects via eye-gaze commit](/assets/img/unit-4/eye-gaze-commit-1.png)

### Head-Gaze and Commit

Head-Gaze and Commit is an input model that involves positioning the user's head in the direction of a target and using a secondary explicit input to confirm intention to select the target (ex: voice command).

The head gaze vector has been shown repeatedly to be usable for fine targeting, but often works best for gross targeting--acquiring larger targets. Minimum target sizes of 1 degree to 1.5 degrees allow successful user actions in most scenarios, though targets of 3 degrees often allow for greater speed. The size that the user targets is effectively a 2D area even for 3D elements--whichever projection is facing them should be the targetable area. Providing some salient cue that an element is "active" (that the user is targeting it) is helpful. This can include treatments like visible "hover" effects, audio highlights or clicks, or clear alignment of a cursor with an element.

![A 3D object being selected via head-gaze and commit](/assets/img/unit-4/head-gaze-commit.png)

Users often fail to find UI elements located either too high or low in their field of view. Most of their attention ends up on areas around their main focus, which is approximately at eye level. Placing most targets in some reasonable band around eye level can help. Given the tendency for users to focus on a relatively small visual area at any time (the attentional cone of vision is roughly 10 degrees), grouping UI elements together to the degree they're related conceptually can use attention-chaining behaviors from item to item as a user moves their gaze through an area. When designing UI, keep in mind the potential large variation in field of view across headsets.

`<image>`

## Quiz

{% include quiz.html file='unit-4-gaze-and-commit' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD