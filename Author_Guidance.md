# Author Guidance

First and foremost, thank you for volunteering to assist with this project! This is currently a private repo that will eventually transition to a pubic repo -- pending the curriculum being completed. This repo structure and naming conventions is consistent with and follows existing curriculum published by Cloud Advocates. For a completed example, visit [aka.ms/webdev-beginners](https://aka.ms/webdev-beginners). Consider everything within this repo to be a work in progress until the curriculum is published.

Fork this repo and create a new branch for your respective lesson. Branches follow the naming convention: `<last name>-unit-<unit number>` (ex: `speight-unit-1`).

## Repository Structure

*Units*

Each unit has it's own folder. Within that folder are sub-folders for each lesson. 

*Lessons*

Within each lesson subfolder are the following:

- An `Images` folder which contains all images for the lesson. The naming convention for images is `image_name.png` (for example: `april.png` or `april_speight.png`.)
- A `Readme.md` file which contains the actual text for the lesson
- A `assignment.md` file which contains the assignment for the lesson (if applicable).

> Refer to the [Unit Sample](/Unit-Sample/README.md) for a sample of this structure.

## Getting Started with Visual Studio Code

We suggest using [Visual Studio Code](https://code.visualstudio.com) for authoring. You can clone the repository once in the editor using the Command Palette (Ctrl/Cmd+Shift+P) command **Git: Clone**. Enter the link to the repository `https://github.com/microsoft/intro-to-xr-development.git` and follow the remaining prompts to clone the repository locally.

If you are using Visual Studio Code, consider installing both the [Docs Authoring Pack](https://marketplace.visualstudio.com/items?itemName=docsmsft.docs-authoring-pack) and [GitHub  Pull Request and Issues](https://marketplace.visualstudio.com/items?itemName=GitHub.vscode-pull-request-github) extensions. Both extensions will significantly help with the authoring process. Review the extension documentation to learn more.

## Placeholders

- For link placeholders, use `<LINK>` (ex: `[Microsoft](<LINK>)`)
- For number placeholders, use `<#>` (ex: `There are <#> lessons.`)
- For image placeholders, use `<IMAGE>`
- For all other placeholders not specified above, use `TBD`

## Accessibility and Inclusive Language

Our Microsoft Docs and Learn contributot guides follow the guidance provided within [Accessibility tool and references](https://review.docs.microsoft.com/en-us/help/contribute/contribute-accessibility-guidelines?branch=main). Since this is a 1st-party project within a Microsoft owned repository, we will adhere to the aforementioned guidelines.

If your contribution includes an image, you **must** include alt-text. The Docs Authoring Pack provides the following syntax for alt-text:

```markdown
:::image type="content" source="{source}" alt-text="{alt-text}":::
```

> You can insert images with the Docs Authoring Pack via **Alt+M** > **Image**. Follow the prompts to insert the image and provide alt-text. You'll be able to edit the alt-text in the Markdown file itself.

## Need Help?

If you have any questions, please reach out to **April Speight (apspeigh)** and **Gustavo Cordido (gcordido)**.
