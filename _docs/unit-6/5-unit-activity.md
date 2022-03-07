---
title: Unit Activity
---

# Unit Activity

## Prerequisites

**Unity**

The activity requires you to create an app in [Unity](https://unity.com/). If you don't already have Unity installed, visit [unity.com/download](https://unity.com/download) to download the Unity Hub. This activity can be completed with Unity version **2020.3.20f1** or newer.

**Visual Studio**

This activity requires you to create code in [Visual Studio](https://visualstudio.microsoft.com/downloads/). Ensure that Visual Studio is downloaded and set as the default editor for Unity. If you're unfamiliar with the steps to set Visual Studio as the default editor, review [Set Your Default Script Editor](https://learn.unity.com/tutorial/set-your-default-script-editor-ide#612f3e91edbc2a1b4b4418ee). This activity can be completed with **Visual Studio 2019** or newer.

## Instructions

In this activity, you'll create a Unity project for the basketball game and add GameObjects to the scene. You're welcome to use your own models if you prefer, however, recommended models are provided.

### Project Setup

1. Create a new Unity project using a **3D** template. Name the project **BasketballGame** and save it to your desktop.

    `<image>`

1. In the Unity editor, navigate to **File > Save As** to save the scene. Name the scene **Unit-6**.
1. Provide a **Company Name** and **Product Name** for the app. To do so, navigate to **Edit > Project Settings > Player**.
1. In the **Project** window, create the following 4 folders inside the **Assets** folder:
    - Materials
    - Models
    - Prefabs
    - Scripts

    To create a new folder, right click into the **Assets** folder and select **Create > Folder**.

    `<image>`

### Create a Basketball Court

The scene needs to be grounded onto a flat surface so that the player has a surface to move back and forth on to take a shot. The **Plane** primitive is ideal for creating flat ground surfaces. Create a basketball court for the game.

1. In the **Hierarchy** window, right click and select **3D Object > Plane**. Name the object **Court**.

    `<image>`

1. Create and assign a **Material** to the **Court** GameObject. To create a new material, in the **Project** window, right click into the **Materials** folder and select **Create > Material**. Using the **Albedo** property, choose a color of your choice.

    `<image>`

### Create a Player

The game needs an object to serve as the player for the game. Since this is a prototype, you can use a Unity primitive (such as a **Cube** reshaped to a vertical rectangle) to represent the player. Create a player and reposition so that they're leveled with the basketball court.

1. In the **Hierarchy** window, right click and select **3D Object > Cube**. Name the object **Player**.

    `<image>`

1. Modify the **Player Transform Scale Y** to **4**. This extends the height of the **Player** GameObject to create a vertical rectangle.

    `<image>`

1. Create and assign a **Material** to the **Player** GameObject. To create a new material, in the **Project** window, right click into the **Materials** folder and select **Create > Material**. Using the **Albedo** property, choose a color of your choice.

    `<image>`

1. The **Player** is positioned in the middle of the court. Raise the player so that they're leveled with the ground. Modify the **Player Transform Position Y** to **2**.

    `<image>`

1. Since the basketball hoop will display on the far end of the court, the **Player** should be positioned at the opposite end of the court. Modify the **Player Transform Position Z** to **-4**.

    `<image>`

### Create a Basketball Hoop

The basketball hoop floats vertically back and forth in the game. The hoop needs to float within the width of the basketball court. Create or import a basketball hoop model and add a script component that provides continuous horizontal movement.

1. [Download](https://www.cgtrader.com/free-3d-models/sports/equipment/basket-ball-hoop-cde8ef2d-fe2c-49db-962f-bd79d410c299) the basketball hoop model from CGTrader.

    `<image>`

1. Rename the model **basketball-hoop** and drag the model into the **Project** window's **Models** folder to import into your project.

    `<image>`

1. Drag the **basketball-hoop** model into the scene. The model comes with it's own **Camera** GameObject. Expand the children of the **basketball-hoop** GameObject and disable the **Camera** GameObject.

    `<image>`

1. The **basketball-hoop** needs to be resized to fit the scale of the **Player**. Modify the **basketball-hoop Transform Scale** to **0.5, 0.5, 0.5**.

    `<image>`

1. The **basketball-hoop** should be positioned at the opposite end of the **Court**. Modify the **basketball-hoop Transform Position Z** to **4**.

    `<image>`

1. Now that the **basketball-hoop** is in position, create a script that'll move the object horizontally back and forth within the width of the **Court**. To create a new script, in the **Project** window, right click into the **Scripts** folder and select **Create > C# Script**. Name the script **HoopMovement** and double click to compile and open in Visual Studio.

    `<image>`

1. In Visual Studio, add the following script and save (WILL PROVIDE EXPLANATION LATER):

    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class HoopMovement : MonoBehaviour
    {
        private Vector3 startPosition;
    
        [SerializeField]
        private float frequency = 5f;
    
        [SerializeField]
        private float magnitude = 5f;
    
        // Start is called before the first frame update
        void Start()
        {
            startPosition = transform.position;
        }
    
        // Update is called once per frame
        void Update()
        {
            transform.position = startPosition + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
        }
    }
    
    ```

1. In the Unity editor, add the **HoopMovement** script as a component to **basketball-hoop**. You can do so by either dragging the script onto the parent GameObject.

    `<image>`

1. Press **Play** to test the script.

    `<image>`

    Adjust the **Frequency** and **Magnitude** so that the **basketball-hoop** moves at your desired speed within the width of the **Court**.

### Create a Basketball Prefab

Each time the player takes a shot, a new ball instantiates so that they can take another shot. Create or import a basketball model and turn the model into a prefab.

1. [Download](https://sketchfab.com/3d-models/basketball-536d687777f0473dbc79f00ea4a17917) the basketball model from Sketchfab. After the model downloads, unzip the content within the folder.

    `<image>`

1. Drag the model's folder into the **Project** window's **Models** folder to import into your project.

    `<image>`

1. Drag the **basketball** model into the scene. The **basketball** needs to be resized to fit the scale of the **Player**.Modify the **basketball Transform Scale** to **.04, .04, .04**.

    (Note: To fully view the **basketball**, you may need to increase the **Position Y**. Be sure to change back to **0** before proceeding to the next step.)

    `<image>`

1. Imported models are already created as a prefab. However, you can modify the prefab and either save the changes to the original prefab *or* create as a new prefab variant. Drag the **basketball** model into the **Prefabs** folder and create as a **Prefab variant**. Rename the model **basketball**.

    `<image>`

    Note: If you chose to create your own basketball from scratch, drag the basketball model into the **Prefabs** folder to create as a prefab.

1. Now that the **basketball** prefab has been created, delete the existing **basketball** GameObject into the **Hiearchy**. If you drag the new prefab into the **Hierarchy** window, the prefab will reflect the configuration you created for the prefab.

    `<image>`

## Solution

To view the project sample for this activity, download the [Unit 6 Activity Project](LINK).