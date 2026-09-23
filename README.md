# 2D Platformer in Unity

This repository contains our classwork 13, which we worked on in pairs. We made a simple scene where the player controls a rectangle that can move and jump between platforms to reach a goal.

The purpose was to practice character movement, collisions, and activating interface elements through C# scripts.

## What did we do?

We worked on SampleScene. The character can move left and right and jump when standing on a surface.

We added four orange rectangular obstacles and three new platforms. We used different colors to make the player, obstacles, and platforms easy to tell apart during the game.

We also added a goal with a flag image. When the player touches it, a message appears, and the character stops moving.

The message is inside a Canvas. This Canvas is part of the scene hierarchy, but it starts disabled and becomes visible when the player reaches the goal.

## Controls

- A or left arrow: move left.
- D or right arrow: move right.
- Spacebar: jump.

If the player falls off the level, they return to their starting position to try again.

## Team members
Rodrigo Zatarain Aguirre and Cesar Ernesto Perez Gomez.


# How to download and open our project in Unity

To try our project, you need Unity Hub and the Unity Editor installed. We used version 6000.5.7f1, so we recommend opening it with that same version.

The repository already contains a complete Unity project. You can download it and open it directly through Unity Hub.

## 1. Open the repository

Open this link:

https://github.com/0267814/RodrigoCesarClasswork.git

## 2. Download the files

Click the green Code button and select Download ZIP.

Once the download finishes, extract the ZIP file into a folder on your computer. For example, you could save it in a folder called Unity Projects inside Documents.

You need to extract the files before opening the project.

## 3. Find the project folder

Open the folder you just extracted. It should contain these folders:

- Assets
- Packages
- ProjectSettings

This is the folder you need to add to Unity Hub. If extracting the ZIP created a folder inside another folder, open it until you find the three folders listed above.

## 4. Add the project to Unity Hub

Open Unity Hub and go to the Projects section.

Find the option to add an existing project from your computer and select the folder you identified in the previous step.

After adding it, the project will appear in Unity Hub’s project list.

## 5. Open it with the correct version

Open the project using Unity 6000.5.7f1. If you do not have that version installed yet, install it before continuing.

Opening the project for the first time may take a while because Unity needs to import the assets and prepare the project files. Wait for that process to finish.

You can also find the Canvas Victoria object in the Hierarchy window. It will be disabled before you win and will activate when the player touches the goal.

To stop testing, press Play again. If you want to start another round, enter Play mode again.
