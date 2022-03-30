---
title: XR Input
---

# XR Input

## Objectives

- TBD
- TBD
- TBD

## Introduction

When you play a game or interact with a 2D experience on a computer, more often you'd use a keyboard and/or mouse for input. Input for XR apps and experiences go beyond traditional keyboard/mouse input and instead enables users to provide input with controllers, hands, voice, eye position, head position, and haptic devices. While most of these input types are common across XR device categories, accessing these features can vary significantly between platforms.

### XR Input Mapping

Input mapping enables you to map user input to a corresponding button or key on a controller. Unity has identified a standard set of physical device controls (such as buttons and triggers) to access user input on any platform -- it is referred to as `InputFeatureUsage`. Each `InputFeatureUsage` corresponds to a common input action or type.

Unity provides input mappings across several XR devices:

- Windows Mixed Reality (WMR)
- Oculus
- GearVR
- Daydream
- OpenVR (Full)
- Vive
- Oculus via OpenVR
- WMR via OpenVR
- Magic Leap

However, you're not limited to the devices outlined above. You're welcome to create input mappings for other controllers.

### Touch Screens for Mobile Devices

Mobile XR apps and experiences more often requires touch-screen input. The capabilities differ between mobile iOS and Android devices. Mobile iOS devices (iPhone and iPad) are capable of tracking five fingers touching the screen simultaneously. However, Android devices don't have a unified limit across devices on how many fingers can be tracked.

The `Input.Touch` enables you to get the status of a finger touching the screen. Accessing this information is helpful for script logic that triggers an action based on when a user touches the screen. You can use this information to define logic such as making text visible once a finger has been lifted from the screen.

## Quiz

{% include quiz.html file='unit-7-xr-input' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [XR Input - Unity Documentation](https://docs.unity3d.com/Manual/xr_input.html)
- TBD
- TBD