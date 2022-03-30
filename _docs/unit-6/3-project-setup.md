---
title: Project Setup
---

# Project Setup

## Objectives

- TBD
- TBD
- TBD

## Introduction

The first step in creating any Unity-based application is to setup the project. The steps for project setup depends on the target platform/platforms, as well as the type of application you want to create.

### Build Settings

The **Build Settings** contain options you can use to set up and begin the build process for your application on the respective platform(s). It contains settings to create builds - both for development builds and final builds. While this window is most likely to be utilized once you're ready to build and deploy your app, it's helpful to switch to the appropriate platform pre-development as some imported SDKs and assets may depend on having the appropriate platform selected.

 The Build Settings are accessed by navigating to **File > Build Settings**.

![A screenshot of Unity's build settings, including scenes, platform and platform settings](/assets/img/unit-6/build-settings.png)

The Build Settings window contains three sections:

- Scenes in Build (Figure #, A): A list of scenes that are included in the build.
- Platform (Figure #, B): The target operating system for the build. Common platforms for XR development are Universal Windows Platform (UWP), Android, and iOS.
- Platform Settings (Figure #, C): The build settings for the respective platform.

### Project Settings

Unity provides various project settings across 20 categories. For a beginner in XR development, we'll primarily focus on the Player and XR Plug-in Management settings. As you become more familiar with the editor, you'll later find the need to configure other settings that'll enhance your project.

The Project Settings are accessed by navigating to **Edit > Project Settings**.

![A screenshot of Unity's Project Settings](/assets/img/unit-6/project-settings.png)

#### Player Settings

The **Player** settings determine how Unity will build and display the final application. Within these settings, you can provide your company's name, product name, application version, and a default icon for the app. There are also additional platform-specific settings.

![A screenshot of Unity's Player Settings](/assets/img/unit-6/player-settings.png)

#### XR Plug-in Management Settings

The **XR Plug-in Management** settings are used to configure your project for XR development. Settings are configured based on the plug-in for your target platform. If you're not developing for one specific platform, rather you're creating an app that targets multiple platforms, you can use the OpenXR plugin. **OpenXR** enables you to seamlessly target a wide range of AR/VR devices.

![A screenshot of Unity's XR Plug-in Management](/assets/img/unit-6/xr-plugin.png)

## Quiz

{% include quiz.html file='unit-6-project-setup' %}

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [Project Settings](https://docs.unity3d.com/Manual/comp-ManagerGroup.html)
- [Player Settings](https://docs.unity3d.com/Manual/class-PlayerSettings.html)
- [Configuring Your Unity Project for XR](https://docs.unity3d.com/Manual/comp-ManagerGroup.html)
- [OpenXR Overview](https://youtu.be/PxPIr_C5s7k)