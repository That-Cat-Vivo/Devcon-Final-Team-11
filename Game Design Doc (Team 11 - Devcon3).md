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


# Citations

3D Fruit:
https://assetstore.unity.com/packages/package/284706

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


TODO: ** Remember to remove **
Include additional sections as define by your team. We expect about 3 additional sections _of substance_. By this, we mean it adds tangible value in explaining your idea, showing exploration, or displaying concepts visually. For instance, a section on target platform is not tangibly valuable.