Hands-Free

## Objectives

- *Objective 1*
- *Objective 2*
- *Objective 3*

## Introduction

The hands-free model is ideal for applications that require users to use one or two hands to interact with their real-world environment. This model prevents hand fatigue and reduces the learning curve for understanding how to interact with digital objects and triggering actions.

Consider this input model for the following scenarios:

- example
- example
- example
- example

There are two modalities for the hands-free input model:

- Voice Input
- Gaze and Dwell

### Voice Input

Using your voice to command and control an interface offers a convenient way to operate hands-free. With **voice input**, the user can say a keyword to trigger an action. Voice input can be a natural way to communicate your intent. Voice is especially good at traversing complex interfaces, because it lets users cut through nested menus with one command. Because users speak with different kinds of dialects and accents, proper choice of speech keywords will make sure your user's commands are interpreted unambiguously. Furthermore, consider aiding command discovery by implementing an affordance such as a list of possible commands that pops up when a user gazes at an object.

<`image`>

#### Advantages for Voice Input

A user might say "go back" while looking at a webpage, instead of having to go up and hit the back button in the app. This small time saving has a powerful emotional effect on user’s perception of the experience and gives them a small amount superpower. Using voice is also a convenient input method when we have our arms full or are multi-tasking. On devices where typing on a keyboard is difficult, voice dictation can be an efficient alternative way to input text. Lastly, in some cases, when the range of accuracy for gaze and gesture are limited, voice can help to disambiguate the user's intent.

#### Challenges for Voice Input

*Voice Input for Continuous Control* 

A user might want to change their volume in their music app. They can say "louder", but it's not clear how much louder the system is supposed to make the volume. The user could say: "Make it a little louder", but "a little" is difficult to quantify. Moving or scaling 3D objects with voice is similarly difficult.

*Reliability of Voice Input Detection*

While voice input systems become better and better, sometimes they may incorrectly hear and interpret a voice command. The key is to address the challenge in your application. Providing feedback to your users when the system is listening and what the system understood clarifies potential issues understanding the users's speech. Consider implementing a visual indicator such as a microphone icon when the app is listening or displaying visual text confirmation of what the user said.

`<image>`

*Voice Input in Shared Spaces* 

Voice may not be socially acceptable in spaces that you share with others. Here are a few examples:

- The user may not want to disturb others (ex: in a quiet library or shared office)
- Users may feel awkward being seen talking to themselves in public
- A user may feel uncomfortable dictating a personal or confidential message (including passwords) while others are listening

*Voice Input of Unique or Unknown Words*

Difficulties for voice input also come when users are dictating words that may be unknown to the system, such as nicknames, certain slang words, or abbreviations.

*Learning Voice Commands*

While the ultimate goal is to naturally converse with your system, often apps still rely on specific pre-defined voice commands. A challenge associated with a significant set of voice commands is how to teach them without overloading the user and how to help the user to keep them.

#### Design Guidance for Speech Recognition

Below are some practices that will aid in smooth speech recognition.

*Use concise commands*

When possible, choose keywords of two or more syllables. One-syllable words tend to use different vowel sounds when spoken by persons of different accents. For example, "Play video" is better than "Play the currently selected video".

*Use simple vocabulary*

Use plain-speak for utterances. For example, "Show note" is better than "Show placard".

*Make sure commands are non-destructive*

Make sure any speech command actions are non-destructive and can easily be undone in case another person speaking near the user accidentally triggers a command.

*Avoid similar sounding commands*

Avoid implementing multiple speech commands that sound similar. For example:, "Show more" and "Show store" can be similar sounding.

*Test with different accents*

Test your app with users of different accents. For example, a southern US accent sounds different compared to a British UK accent.

*Maintain voice command consistency*

If "Go back" goes to the previous page, maintain this behavior in your application.

*Avoid using system commands*

Some commands are reserved for the device's system. For example, avoid using them in your application.

### Gaze and Dwell

In some hands-free situations, using your voice isn't ideal or even possible. Loud factory environments, privacy, or social norms can all be constraints. The gaze and dwell modality allows the user to navigate an app without any extra input aside from their eye or head gaze: The user keeps gazing (with their head or eyes) at the target and lingers there for a moment to activate it. There arw two variants of gaze and dwell: Eye-Gaze and Dwell and Head-Gaze and Dwell.

#### Eye-Gaze and Dwell

**Eye-Gaze and Dwell** is an input model that involves looking at a target and using a secondary explicit input to confirm the intention to select the target. With this approach, even severely constrained users who can't fully turn their heads or bodies can interact with virtual objects (for example, in a highly confined work environment). Pair the user's head gaze with a cursor or other auditory/visual indication to give the user confidence in what they're about to interact with. Such a cursor is typically positioned where the head gaze ray first intersects an object (ex: a virtual object or real-world surface). It's recommended not to show a cursor for eye-gaze as the cursor can quickly become distracting and annoying for the user. Instead, subtly highlight visual targets or use a faint eye cursor to provide confidence about what the user is about to interact with.

<`image`>

It's recommended to only use dwell-based activations as a last fall-back if neither voice input nor hand input is available. The reason is that the choice of dwell time can be tricky. Novice users are ok with longer dwell times, while expert users want to quickly and efficiently navigate through their experiences. This leads to the challenge of how to adjust the dwell time to the specific needs of a user. If the dwell time is too short, the user may feel overwhelmed by having virtual objects react to their eye-gaze all the time. If the dwell time is too long, the experience may feel too slow and interruptive as the user has to keep looking at targets for a long time.

#### Head-Gaze and Dwell

**Head-Gaze and Dwell** is an input model that involves positioning the user's head in the direction of a target and taking the duration of the position as a trigger for selection. The headset uses position and orientation of the user's head to determine their head direction vector. This approach is 100% reliable independent of noise interference and silence constraints in the operating environment.

Head-gaze and dwell is great in scenarios where a person's hands are busy with other tasks. The feature is also useful when voice isn't 100% reliable or available because of environmental or social constraints. A good example is a person wearing a head-mounted device to overlay reference information while repairing a car engine. Their hands are busy with tools or supporting their body as they lean into the engine compartment. The garage space is loud, with the constant banging and buzzing of tools, making voice commands difficult. Head-gaze and dwell allows the person wearing the headset to confidently navigate their reference material without interrupting their workflow.

<`image`>

#### Design Guidance for Dwell

*Avoid "Gaze as a weapon"*

Eye or Head-Gaze and Dwell requires visual feedback to be intuitive, but too much feedback can induce anxiety. The feedback should help a user know what they're targeting, but not auto-select it against their intent. When reading text, icons, and labels, you need to provide users time to absorb the information before selecting.

*Seek Goldilocks speed*

Dwell interactions can have different timers based on impact of navigation - more frequently used functions will generally benefit from faster fill times, while more consequential functions may benefit from longer fill times. When using a fill-effect to show these timers, animation curves of the fill color can positively influence a feeling of faster fill times. Consideration should be taken to enable user decision from fast/medium/slow fill speed overrides.

<`image`>

*Say no-no to yo-yo effect*

The yo-yo effect is an uncomfortable head movement pattern that happens when the content placement and eye/head-gaze and dwell controls forces people to look up and down repeatedly. For example, a list navigation with the head-gaze and dwell button at the bottom induces a loop of: look down to dwell, look up at results, look down to dwell, and so on. The resulting pattern is uncomfortable, thus it's recommended to place navigation controls in a centralized location that requires less back-and-forth. Placement of dwell buttons based on their effects becomes important for comfort.

<`image`>

*Target Sizes*

To be easily accessible, eye/head-gaze and dwell targets need to be large enough to look at comfortably, and hold one's eyes or head stable on the target for the prescribed time. A minimum target size of 2 degrees is recommended to achieve the most comfortable experience.

<`image`>

*High Frequency Buttons*

High frequency buttons are buttons that are used commonly throughout an application. High frequency buttons should be large, easier to select with eye/head-gaze. Furthermore, stay near eye heigh to avoid ergonomic straining.

<`image`>

*Low Frequency Buttons*

Low frequency buttons are buttons that aren't interacted with as regularly throughout the application. A good example might be a button to access the settings menu, or a button to clear all work. Try to keep these buttons out of the way of frequent eye/head-gaze paths to avoid accidental activation.

<`image`>

*Toggle Buttons*

Toggle buttons require some nuanced logic to work properly. When a person dwells on a toggle button and activates it, they need to exit the button and then return to restart the dwell logic. It's important that togglable buttons have a clear active versus inactive state.

<`image`>

*List Views*

List views present a particular challenge for eye/head-gaze and dwell input. People can scan the content without feeling like that have to tiptoe around the dwell targets. For list views, highlight the entire row for eye/head-gaze but don't begin dwell unless eye/head-gaze is on the specific dwell target. You should only show one dwell target when the row is highlighted to cut down on visual noise and to avoid repetitive user interface elements. Be clear and consistent with the position of dwell targets.

<`image`>

*Confirmations*

When an action has significant impact, like charging money, deleting work, or starting a long process, it's useful to confirm that a person meant to select a button. Reveal the dwell target and show the selection highlight on the main button at the same time. For the secondary button, reveal the dwell target on the eye/head-gaze.

`<image>`

#### Design Guidance for Dwell Feedback

Consider using a two-state approach for dwell feedback:

*Onset Delay*

When the user starts looking at a target, nothing should immediately happen as this may result in an unpleasant and overwhelming user experience. Instead start a timer to detect whether the user is intentionally staring at the target or merely glancing over it. The recommended onset time is 150-250 ms in a given proximity (meaning the user is fixating vs. looking around on a large target).

*Start Dwell Feedback*

After ensuring that the user is intentionally looking at the target, start showing dwell feedback to inform the user that the dwell activation is being initiated.

*Continuous Feedback*

While the user keeps looking at the target, show a continuous progress indicator so that the user knows that they have to keep looking at the target. For example, you could pull in the user's visual attention by starting out with a bigger circle or sphere that contracts into a smaller version. Showing an indicator for the final state (small circle) helps to communicate to the user when the dwell will be finished.

*Finish*

If the user kept fixating the target (for another 650-850 ms), complete the dwell activation and select the looked-at target.