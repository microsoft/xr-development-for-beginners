# Build Settings

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Introduction

The build settings contain options you can use to set up and begin the build process for your application on the respective platform(s). It contains settings to create builds - both for development builds and final builds. The Build Settings window is accessed by navigating to **File > Build Settings**.

`<image>`

The Build Settings window contains three sections:

- Scenes in Build (Figure #, A): A list of scenes that are included in the build.
- Platform (Figure #, B): The target operating system for the build. Common platforms for XR development are Universal Windows Platform (UWP), Android, and iOS.
- Platform Settings (Figure #, C): The build settings for the respective platform.

### Universal Windows Platform
To build and run for Windows, you must install the Unity **Universal Windows Platform Build Support** platform module. Universal Windows Platform only shows in the Platform list if you're using Unity on a Windows computer. You'll also need Windows 10 and a Visual Studio 2019 (16.8 or higher). Visual Studio requires the following workloads:

- Desktop development with C++
- Universal Windows Platform (UWP) development
- Game development with Unity

Within the UWP workload, make sure the following components are included for installation:

- Windows 10 SDK version 10.0.19041.0 or 10.0.18362.0
- USB Device Connectivity
- C++ (v142) Universal Windows Platform tools

The main workflow when building an application for UPW using Unity is as follows:

1. Unity generates and exports a Visual Studio Project to the path that you select.
1. Open the generated Project's *.sln* file in Visual Studio.
1. Use Visual Studio to build your final application.

When you click **Build and Run**, Unity builds an app executable that can run independently.

### Android

To build and run for Android, you must install the Unity **Android Build Support** platform module. You also need to install the Android Software Development Kit (SDK) and the Native Development Kit (NDK) to build and run any code on your Android device. By default, Unity installs a Java Development Kit based on OpenJDK.

You can connect your Android device to your computer for both USB debugging and installing your app onto the deice. USB debugging requires that you enable Developer options on your device. Once enabled, you can connect your device to your computer using a USB cable. If you are developing on a Windows computer, you might need to install a device-specific USB driver.

The main workflow when building an application for Android using Unity is as follows:

1. Unity generates and exports an APK and OBB package to the path that you select.
1. Install the packages on your device manually using the Android Debug Bridge (ADB) Publish the package to the Google Play Store OR
1. Publish the packages to the Google Play Store.

Selecting **Build and Run** saves the output packages to the file path you specify, while also installing your app on the Android device connected to your computer.

### iOS

To build and run for iOS, you must install the Unity **iOS Build Support** platform module. While you don't need an Apple Developer account to build to devices, it's recommended to set up an Apple Developer account to use Unity to it's full potential with iOS.

The main workflow when building an application for iOS using Unity is as follows:

1. Unity generates and exports an XCode project.
1. Open the generated XCode project in XCode.
1. Compile and sign the app.
1. Deploy the app to your device.

## Quiz

[Start Quiz](LINK)

## Supplemental Reading

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- TBD
- TBD
- TBD