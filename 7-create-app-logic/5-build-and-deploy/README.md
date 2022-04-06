# Build and Deploy

## Objectives

- Summarize the build and deployment steps for Universal Windows Platform.
- Summarize the build and deployment steps for Android.
- Summarize the build and deployment steps for iOS.

## Introduction

When you're ready to install your project onto your device, you must complete a build. A **build** converts the project into a stand-alone form that can be run on a device. The build time varies by project as it's dependent on various factors such as the project's size and your computer's CPU. Once a build is complete, the output is a version of the app that can be installed (or deployed) to a device.

### Universal Windows Platform

The main workflow when building an application for UPW using Unity is as follows:

1. Unity generates and exports a Visual Studio Project to the path that you select.
1. Open the generated Project's *.sln* file in Visual Studio.
1. Use Visual Studio to build your final application.

When you click **Build and Run**, Unity builds an app executable that can run independently.

### Android

You can connect your Android device to your computer to install your app onto the deice. The main workflow when building an application for Android using Unity is as follows:

1. Unity generates and exports an APK and OBB package to the path that you select.
1. Install the packages on your device manually using the Android Debug Bridge (ADB) OR
1. Publish the packages to the Google Play Store.

Selecting **Build and Run** saves the output packages to the file path you specify, while also installing your app on the Android device connected to your computer.

### iOS

The main workflow when building an application for iOS using Unity is as follows:

1. Unity generates and exports an XCode project.
1. Open the generated XCode project in XCode.
1. Compile and sign the app.
1. Deploy the app to your device.

## Post-Lecture Quiz

[Quiz](https://ashy-plant-023e6671e.1.azurestaticapps.net/quiz/24)

## Review and Self Study

We've identified the following resources to provide additional context and learning for the content reviewed in this lesson. We encourage you to review the material below and explore additional related topics.

- [Deploying to HoloLens and WMR Headsets (MRTK)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/supported-devices/wmr-mrtk?view=mrtkunity-2021-05)
- [Deploying to Oculus Quest (MRTK)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/supported-devices/oculus-quest-mrtk?view=mrtkunity-2021-05)
- [Deploying to Android and iOS (AR Foundation)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/supported-devices/using-ar-foundation?view=mrtkunity-2021-05)