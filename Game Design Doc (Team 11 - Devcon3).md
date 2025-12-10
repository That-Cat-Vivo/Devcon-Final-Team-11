# Overview

We are making a physics based ball and maze game. You have to move the ball from the start position to the finish position, avoiding the obstacles in the maze.

Controls:
W: Tilts top edge up
A: Tilts left edge up
S: Tilts bottom edge up
D: Tilts right edge up

# Objective Statement

How do physics metrics be leveraged to create a simple physics based maze game?

# Design Rationale

We envisioned a game like the plastic maze games with the metal ball. This game could be single or multiplayer, where one player controls one axis and the other player controls the other. The game would also involve physics for the ball that would make it move pretty realistically. The game is engaging because it even though it leverages physics and metrics the game is still pretty arcadey. It also gives the player a pretty good challenge without being too challenging.

# Metric Research and References

We have utilized fruit as a reference for the physics properties and size of the "ball," which is in this game an apple. 
The average size of an apple is 2-4" in Diameter. (Apprx 5-10 cm.) The apple in the game is meant to be 3" in diameter. (Apprx 7.6cm.) 
To indicate the size of the apple to the player, we needed something that could be compared. Thus the edges of the maze were decorated with bananas, their lengths twice that of the apple. (Bananas are apprx 7-8"/17-20cm in length. Our bananas take the median.)
We gave the apple a mass of 3, which gave it the inertia expected of such an object. While this was not exactly measured, we rolled an apple around to get the feel of said inertia and replicated that.
The base gravity of the scene is set to (0, -9.0f, 0). This allowed for the friction of the Maze to properly affect the apples rolling, and ensured a realistic reaction to the tilting of the maze.
The maze was meant to be made out of marble, like that of a kitchen countertop. Kitchen counters widely vary in their friction, thus an exact friction was not necessary. We utilized a dynamic friction of 3, which allowed for the apple to not become impossible to control, while still rolling like a proper object. 

# Tilting (Ethan Muller)

The common physics of a ball maze game involves the tilting of the maze so that gravity pulls the ball in a specific direction. Attempting to directly recreate this form of control in Unity had several issues.
Due to both the ball and maze moving separatly from each other, the ball would often phase through and escape the play area.
To counteract this issue, I instead allowed the player to tilt the scenes gravity, in conjunction with the camera, to create the illusion of the maze actually tilting. After all, the forces of gravity are relative.
To ensure the camera would have a smooth transition to the different tilt states, I had five recorded quaternions for the baseRotation, then tilting up, down, left, and right. I then had a Quaternion.Lerp between the current rotation and target rotation. The current rotation would then be continually updated to the resulting rotation, until it was practiacally the same as the target Lerp.
This resulted in a smooth camera change.

# Citations

3D Fruit:
https://assetstore.unity.com/packages/package/284706

Marble Textures: <br>

<a href="http://www.freepik.com">http://www.freepik.com Designed by Kjpargeter / Freepik</a><br>

<a href="http://www.freepik.com">http://www.freepik.com Designed by Freepik</a><br>

# Playtest Notes and Feedback

###### Collision:

Make sure collision is working properly as the ball falls through the maze if its moved too quickly (i suggest looking into Continuous Collision Detection)

Fixing the ball colliding with the maze would be great, also the ball falling even if you're not tilting it its a bit annoying.

The ball seems to have a bit of a bizarre relationship with the map, sometimes disappearing / falling through where there is no hole. I would double check the colliders on the asset, and the FBX import to make sure there isn't some conflicting collider nonsense going on.

The collider issue is pretty significant with the ball sometimes clipping through the floor, seemingly when turning the maze quickly and colliding with one of the walls.

The ball falls out of the game on almost every movement, perhaps add some more walls to keep it in the board, or change the gravity to keep the ball on the ground

The physics with the ball still feel a bit clunky shaking the box a lot causes the ball to disappear.

###### Ball Movement:

Make the ball move faster to add more of a challenge, as it felt pretty safe to move the ball carefully as it were.

The board/box movement is clean and responsive

###### Controls:

The controls feel inverted, but that could just be me



TODO: \*\* Remember to remove \*\*
Include additional sections as define by your team. We expect about 3 additional sections *of substance*. By this, we mean it adds tangible value in explaining your idea, showing exploration, or displaying concepts visually. For instance, a section on target platform is not tangibly valuable.

