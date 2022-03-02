# Scene Elements

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Introduction

An app's scene contains various objects that bring your XR experiences to life. While some are optional, there are three required objects which must be included in scenes to render a 3D environment:

- GameObjects
- Lights
- Cameras

By default, Unity provides both a light and camera for newly created scenes. It is up you to include an object to render and modify the default objects to suit your app's needs.

### GameObjects

Every object in your game is a **GameObject**, from characters and collectible items to lights, cameras and special effects. However, a GameObject can’t do anything on its own; you need to give it properties before it can become a character, an environment, or a special effect. 

GameObjects do not accomplish much in themselves but they act as containers for Components. **Components** define the behavior or functionality of the GameObject. Depending on what kind of object you want to create, you add different combinations of components to a GameObject. Unity has a lot of different built-in component types, and you can also make your own components with scripts.

`<image>`

Components on a GameObject are viewable in the Inspector window. Within each component are different **properties** that can be adjusted in the Editor or with scripts.

GameObjects always have a Transform component attached which represents position, orientation, and scale. The Transform component is the only component that cannot be removed.

`<image>`

In the Hierarchy window, a check box displays next to the GameObject's name which indicates whether the object is active. When unmarked, the GameObject is temporarily removed from the Scene. For nested GameObjects, all child GameObjects are deactivated if it's parent GameObject is deactivated.

`<image>`

### Cameras

A Unity scene represents GameObjects in a three-dimensional space. Since the viewer’s screen is two-dimensional, Unity needs to capture a view and “flatten” it for display. It does this using cameras.  Just as cameras are used in films to display the story to the audience, cameras in Unity are used to display the app scene to the user. You will always have at least one camera in a scene, but you can have more than one. For example, multiple cameras can give you a two-player split-screen.

`<image>`

In Unity, you create a camera by adding a Camera component to a GameObject. What a camera sees is defined by its transform and its Camera component. The transform position defines the viewpoint, its forward (Z) axis defines the view direction, and its and upward (Y) axis defines the top of the screen. Settings on the Camera component define the size and shape of the region that falls within the view. With these parameters set up, the camera can display what it currently “sees” to the screen. As the GameObject moves and rotates, the displayed view moves and rotates accordingly.

`<image>`

*Perspective and Orthographic Cameras*

A camera in the real world, or a human eye, sees the world in a way that makes objects look smaller the farther they are from the point of view. This well-known **perspective** effect is widely used in art and computer graphics and is important for creating a realistic scene.

`<image>`

Unity supports perspective cameras, but for some purposes, you want to render the view without this effect. For example, you might want to create a map or information display that is not supposed to appear exactly like a real-world object. A camera that does not diminish the size of objects with distance is referred to as **orthographic** and Unity cameras also have an option for this. The perspective and orthographic modes of viewing a scene are known as camera projections.

`<image>`

Both perspective and orthographic cameras have a limit on how far they can “see” from their current position. The limit is defined by a plane that is perpendicular to the camera’s forward (Z) direction. This is known as the **far clipping plane** since objects at a greater distance from the camera are “clipped” (i.e., excluded from rendering). There is also a corresponding **near clipping plane** close to the camera - the viewable range of distance is that between the two planes.

Without perspective, objects appear the same size regardless of their distance. This means that the viewing volume of an orthographic camera is defined by a rectangular box extending between the two clipping planes.

`<image>`

When perspective is used, objects appear to diminish in size as the distance from camera increases. This means that the width and height of the viewable part of the scene grows with increasing distance. The viewing volume of a perspective camera, then, is not a box but a pyramidal shape with the apex at the camera’s position and the base at the far clipping plane. The shape is not exactly a pyramid, however, because the top is cut off by the near clipping plane; this kind of truncated pyramid shape is known as a **frustum**. Since its height is not constant, the frustum is defined by it's **aspect ratio** which is the ratio of its width to its height, and  the **field of view** (FOV) which is the angle between the top and bottom at the apex.

`<image>`

### Lights

Lights are an essential part of every scene. They define the color and mood of your 3D environment. You’ll likely work with more than one light in each scene. Lighting in Unity works by approximating how light behaves in the real world - this also includes the light's **intensity** which is it's color and brightness. Unity uses detailed models of how light works for a more realistic result, or simplified models for a more stylized result. Light's other counterpart, shadows, add a degree of depth and realism to a Scene because they bring out the scale and position of objects that might otherwise look flat. In Unity, Lights can cast shadows from a GameObject onto other parts of itself, or onto nearby GameObjects.

`<image>`

*Direct and indirect lighting*

**Direct light** is light that is emitted, hits a surface once, and is then reflected directly into a sensor (for example, the eye’s retina or a camera). **Indirect light** is all other light that is ultimately reflected into a sensor, including light that hits surfaces several times, and sky light. To achieve realistic lighting results, you need to simulate both direct and indirect light.

`<image>`

*Light Types*

There are five types of light:

- Point light
- Spot light
- Directional
- Area light
- Ambient light

*Point lights*

A **point light** is located at a point in space and sends light out in all directions equally. The direction of light hitting a surface is the line from the point of contact back to the center of the light object. The intensity diminishes with distance from the light, reaching zero at a specified range. Light intensity is inversely proportional to the square of the distance from the source.

`<image>`

Point lights are useful for simulating lamps and other local sources of light in a Scene. You can also use them to make a spark or explosion illuminate its surroundings in a convincing way.

*Spot lights*

A **spot light** is located at a point in the Scene and emits light in a cone shape. Like a point light, a spot light has a specified location and range over which the light falls off. However, the spot light is constrained to an angle, resulting in a cone-shaped region of illumination. The center of the cone points in the forward (Z) direction of the light object. Light also diminishes at the edges of the spot light’s cone. Widening the angle increases the width of the cone and with it increases the size of this fade, known as the **penumbra**.

`<image>`

Spot lights are generally used for artificial light sources such as flashlights, car headlights and searchlights. With the direction controlled from a script or animation, a moving spot light will illuminate just a small area of the scene and create dramatic lighting effects.

*Directional lights*

A **directional light** is located infinitely far away and emits light in one direction only. By default, every new Unity scene contains a Directional Light. Directional lights are very useful for creating effects such as sunlight in your scenes. Behaving in many ways like the sun, directional lights can be thought of as distant light sources which exist infinitely far away. A directional light does not have any identifiable source position and so the light object can be placed anywhere in the scene. All objects in the scene are illuminated as if the light is always from the same direction. The distance of the light from the target object is not defined and so the light does not diminish.

`<image>`

Directional lights represent large, distant sources that come from a position outside the range of the game world. In a realistic scene, they can be used to simulate the sun or moon. In an abstract game world, they can be a useful way to add convincing shading to objects without exactly specifying where the light is coming from.

The direction of the light should point slightly downwards but you will usually want to make sure that it also makes a slight angle with major objects in the scene. For example, a roughly cubic object will be more interestingly shaded and appear to “pop” out in 3D much more if the light isn’t coming head-on to one of the faces.

`<image>`

*Area lights*

An **area light** is defined by a rectangle in the Scene, and emits light all directions uniformly across its surface area but only from one side of the rectangle. Since an area light illuminates an object from several different directions at once, the shading tends to be more soft and subtle than the other light types.

`<image>`

You might use it to create a realistic street light or a bank of lights close to an object or the user. A small area light can simulate smaller sources of light (such as interior house lighting) but with a more realistic effect than a point light.

*Ambient lights*

**Ambient light** is light that is present all around a Scene and doesn't come from any specific source object. It can be an important contributor to the overall look and brightness of a scene. Ambient light can also be useful if you need to increase the overall brightness of a scene without adjusting individual lights.

`<image>`

*Real-time and baked lighting*

**Real-time lighting** is when Unity calculates lighting at runtime. **Baked lighting** is when Unity performs lighting calculations in advance and saves the results as lighting data, which is then applied at runtime. In Unity, your Project can use real-time lighting, baked lighting, or a mix of the two (called mixed lighting).

*Global illumination*

**Global illumination** is a group of techniques that model both direct and indirect lighting to provide realistic lighting results. Unity has a global illumination system for both real-time and baked lighting.

### Prefabs

**Prefabs** are a collection of a GameObject's components, property values, and child GameObjects created as a reusable Asset. The Prefab Asset acts as a template from which you can create new Prefab instances in the Scene.

When you want to reuse a GameObject configured in a particular way (ex: a prop or piece of scenery) in multiple places in your Scene, or across multiple Scenes in your Project, you should convert it to a Prefab. This is better than simply copying and pasting the GameObject, because the Prefab system allows you to automatically keep all the copies in sync.

Any edits that you make to a Prefab Asset are automatically reflected in the instances of that Prefab, allowing you to easily make broad changes across your whole Project without having to repeatedly make the same edit to every copy of the Asset.

`<image>`

You can nest Prefabs inside other Prefabs to create complex hierarchies of objects that are easy to edit at multiple levels.

However, this does not mean all Prefab instances have to be identical. You can override settings on individual prefab instances if you want some instances of a Prefab to differ from others. You can also create variants of Prefabs which allow you to group a set of overrides together into a meaningful variation of a Prefab.

You should also use Prefabs when you want to instantiate GameObjects at runtime that did not exist in your Scene at the start. For example, you can create prefabs to make special effects, projectiles, or objects appear at the right moments during app play.

`<image>`