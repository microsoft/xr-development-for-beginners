# Gaze and Commit

*Description of the lesson.*

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Prerequisities

- *Prereq 1*
- *Prereq 2*
- *Prereq 3*

## Introduction

The Gaze and Commit model is a fundamental model that is closely related to the way we interact with our computers using the mouse: Point & click. A user for targets an object or UI element and then interacts or click on it using a secondary input. Gaze and Commit is considered a far input model with direct manipulation. It's best used for interacting with virtual objects or content that is out of reach.

Consider this input model for the following scenarios:

- example
- example
- example
- example

There are two modalities for the gaze and commit input model:

- Eye-Gaze and Commit
- Head-Gaze and Commit

### Eye-Gaze and Commit

Eye-gaze and commit is an input model that involves targeting an object by looking at it and then acting on the target with a secondary commit input (ex: hand gesture, voice command, or peripheral input like a game controller). Our eyes move incredibly fast and are great at quickly targeting across the view. Eye-gaze is ideal for quick gaze-and-commit actions especially when combined with fast commits such as a button press.

#### Design Guidance for Eye-Gaze and Commit

- **Don't show a cursor**: Cursors become quickly distracting and annoying when using eye-gaze. Instead of relying on a cursor to inform the user whether eye tracking is working and has correctly detected the currently looked at target, use subtle visual highlights.
- **Strive for subtle blended hover feedback**: Remember, your eyes are enormously fast, quickly darting across points in your field-of-view. Quick sudden highlight changes (on/off) may result in flickery feedback when looking around. When providing hover feedback, use a smoothly blended-in highlight (and blended-out when looking away). This means at first you would barely notice the feedback when looking at a target. Over the course of 500-1000 ms the highlight would increase in intensity. While novice users could keep looking at the target to ensure the system has correctly determined the focused target, expert users could quickly gaze-and-commit without waiting until the feedback is at its full intensity. Also, consider using a blend-out when fading out the hover feedback. Research has shown that quick motions and contrast changes are noticeable in your peripheral vision (the area of your visual field where you aren't looking). The fade-out doesn't have to be as slow as the blend-in. This is only critical when you have high contrast or color changes for your highlight. If the hover feedback was subtle to begin with, you probably won't notice a difference.
- **Synchronize gaze and commit signals**: For more complicated commit actions, consider the necessary timing between long voice commands or complicated hand gestures. Imagine you look at a target and utter a long voice command. Think about the time you need to say it and the time that the system needed to detect what you said, your eye gaze has long moved on to some new target in the scene. Either make your users aware they may need to keep looking at a target until the command has been recognized or handle the input in a way to determine the onset of the command and what the user had been looking at back then.

### Head-Gaze and Commit

Head-Gaze and Commit is an input model that involves positioning the user's head in the direction of a target and using a secondary explicit input to confirm intention to select the target (ex: voice command).

The head gaze vector has been shown repeatedly to be usable for fine targeting, but often works best for gross targeting--acquiring larger targets. Minimum target sizes of 1 degree to 1.5 degrees allow successful user actions in most scenarios, though targets of 3 degrees often allow for greater speed. The size that the user targets is effectively a 2D area even for 3D elements--whichever projection is facing them should be the targetable area. Providing some salient cue that an element is "active" (that the user is targeting it) is helpful. This can include treatments like visible "hover" effects, audio highlights or clicks, or clear alignment of a cursor with an element.

`<image>`

Users often fail to find UI elements located either too high or low in their field of view. Most of their attention ends up on areas around their main focus, which is approximately at eye level. Placing most targets in some reasonable band around eye level can help. Given the tendency for users to focus on a relatively small visual area at any time (the attentional cone of vision is roughly 10 degrees), grouping UI elements together to the degree they're related conceptually can use attention-chaining behaviors from item to item as a user moves their gaze through an area. When designing UI, keep in mind the potential large variation in field of view across headsets.

#### Design Guidance for Head-Gaze and Commit

- **Head-Gaze Stabilization**: Implement head-gaze stabilization to remove the natural head and neck jitters that users may have. This also includes movement as a result of looking and speaking behaviors.
- **Closest link algorithims**: Such algorithims work best in areas with sparse interactive content. If there's a high probability that you can determine what a user was attempting to interact with, you can supplement their targeting abilities by assuming some level of intent.
- **Backdating and postdating actions**: This mechanism is useful in tasks requiring speed. When a user is moving through a series of targeting and activation maneuvers at speed, it's useful to assume some intent. It's also useful to allow missed steps to act on targets that the user had in focus slightly before or slightly after the tap (50 ms before/after was effective in early testing).
- **Smoothing**: This mechanism is useful for pathing movements, reducing the slight jitter and wobbles because of natural head movement characteristics. When smoothing over pathing motions, smooth by the size and distance of movements rather than over time.
- **Magnetism**: This mechanism can be thought of as a more general version of closest link algorithms -- drawing a cursor toward a target or increasing hit-boxes, whether visibly or not, as users approach likely targets by using some knowledge of the interactive layout to better approach user intent. This can be powerful for small targets.
- **Focus stickiness**: When determining which nearby interactive elements to give focus to, focus stickiness provides a bias to the element that is currently focused. This helps reduce erratic focus switching behaviors when floating at a midpoint between two elements with natural noise.

## Pre-Lecture Quiz Questions & Answers

*NOTE: Use markdown to make the correct answer bold (ex: `**This is the syntax for marking the answer in bold.**`)*

**Question 1**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 2**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 3**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 4**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 5**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

## Post-Lecture Quiz Questions & Answers

**Question 1**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 2**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 3**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 4**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*

**Question 5**

*Question goes here*

Answer Choices:

*Option 1*

*Option 2*

*Option 3*
