# 2D Platformer in Unity

This repository contains our classwork 13, which we worked on in pairs. We made a simple scene where the player controls a rectangle that can move and jump between platforms to reach a goal.

The purpose was to practice character movement, collisions, and activating interface elements through C# scripts.

## What did we do?

We worked on SampleScene. The character can move left and right and jump when standing on a surface.

We added four orange rectangular obstacles and three new platforms. We used different colors to make the player, obstacles, and platforms easy to tell apart during the game.

We also added a goal with a flag image. When the player touches it, a “¡GANASTE!” (“YOU WON!”) message appears, and the character stops moving.

The message is inside an object called Canvas Victoria. This object is part of the scene hierarchy, but it starts disabled and becomes visible when the player reaches the goal.

## Controls

- A or left arrow: move left.
- D or right arrow: move right.
- Spacebar: jump.

If the player falls off the level, they return to their starting position to try again.

## Team members
Rodrigo Zatarain Aguirre and Cesar Ernesto Perez Gomez.
