---
title: Hands Free
---

# Hands-Free

## Objectives

- Summarize the hands free modalities
- Evaluate the impact on leveraging dwell as a form of commit
- Choose a modality best suited for an XR app or experience

## Introduction

The hands-free model is ideal for applications that require users to use one or two hands to interact with their real-world environment. This model prevents hand fatigue and reduces the learning curve for understanding how to interact with digital objects and triggering actions.

There are two modalities for the hands-free input model:

- Voice Input
- Gaze and Dwell

### Voice Input

Using your voice to command and control an interface offers a convenient way to operate hands-free. With **voice input**, the user can say a keyword to trigger an action. Voice input can be a natural way to communicate your intent. Voice is especially good at traversing complex interfaces, because it lets users cut through nested menus with one command. Because users speak with different kinds of dialects and accents, proper choice of speech keywords will make sure your user's commands are interpreted unambiguously. Furthermore, consider aiding command discovery by implementing an affordance such as a list of possible commands that pops up when a user gazes at an object.

![An application with voice-directed commands for the user](/assets/img/unit-4/voice-input.jpg)

Source: [Microsoft](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/input/speech?view=mrtkunity-2021-05)

### Gaze and Dwell

In some hands-free situations, using your voice isn't ideal or even possible. Loud factory environments, privacy, or social norms can all be constraints. The gaze and dwell modality allows the user to navigate an app without any extra input aside from their eye or head gaze: The user keeps gazing (with their head or eyes) at the target and lingers there for a moment to activate it. There are two variants of gaze and dwell: Eye-Gaze and Dwell and Head-Gaze and Dwell.

#### Eye-Gaze and Dwell

**Eye-Gaze and Dwell** is an input model that involves looking at a target and using a secondary explicit input to confirm the intention to select the target. With this approach, even severely constrained users who can't fully turn their heads or bodies can interact with virtual objects (for example, in a highly confined work environment). Pair the user's head gaze with a cursor or other auditory/visual indication to give the user confidence in what they're about to interact with. Such a cursor is typically positioned where the head gaze ray first intersects an object (ex: a virtual object or real-world surface). It's recommended not to show a cursor for eye-gaze as the cursor can quickly become distracting and annoying for the user. Instead, subtly highlight visual targets or use a faint eye cursor to provide confidence about what the user is about to interact with.

![Infographic showing different examples of dwell states](/assets/img/unit-4/eye-gaze-dwell-states.png)
Source: [Microsoft](https://docs.microsoft.com/en-us/windows/mixed-reality/design/gaze-and-dwell-eyes)

It's recommended to only use dwell-based activations as a last fall-back if neither voice input nor hand input is available. The reason is that the choice of dwell time can be tricky. Novice users are ok with longer dwell times, while expert users want to quickly and efficiently navigate through their experiences. This leads to the challenge of how to adjust the dwell time to the specific needs of a user. If the dwell time is too short, the user may feel overwhelmed by having virtual objects react to their eye-gaze all the time. If the dwell time is too long, the experience may feel too slow and interruptive as the user has to keep looking at targets for a long time.

#### Head-Gaze and Dwell

**Head-Gaze and Dwell** is an input model that involves positioning the user's head in the direction of a target and taking the duration of the position as a trigger for selection. The headset uses position and orientation of the user's head to determine their head direction vector. This approach is 100% reliable independent of noise interference and silence constraints in the operating environment.

Head-gaze and dwell is great in scenarios where a person's hands are busy with other tasks. The feature is also useful when voice isn't 100% reliable or available because of environmental or social constraints. A good example is a person wearing a head-mounted device to overlay reference information while repairing a car engine. Their hands are busy with tools or supporting their body as they lean into the engine compartment. The garage space is loud, with the constant banging and buzzing of tools, making voice commands difficult. Head-gaze and dwell allows the person wearing the headset to confidently navigate their reference material without interrupting their workflow.

![An example of a person wearing a headset device, using head-gaze to look select between different objects](/assets/img/unit-4/head-gaze-1.png)

Source: [Microsoft](https://docs.microsoft.com/en-us/windows/mixed-reality/design/gaze-and-commit)

## Quiz

{% include quiz.html file='unit-4-hands-free' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD