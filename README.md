# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

Navigating through Github and Unity was tough. There were so many words and the interface seemed overwhelming. I'm hoping that after this quarter, I can get used to the process and make a fun game out of it. Changing the scene by moving the cat and putting it on the green platform, as well as moving the camera into first-person of the cat was really fun.

### W2

r, g, b values are floats and not strings, bools, or ints because their values have decimal numbers.

_bounce variable is an int beacause its value is how many bounces there are and there cannot be a decimal value for it since there's no half bounce.

A semicolon was missing, so the statement couldn't finish.

### W3

I would put the parameters to be a int variable for the friendship level, and a bool variable for the flag of the character's secret. The return type would be a string variable for the dialogue of the character.

### W4

Table #11
Line 17 describes IsGrounded as a bool member variable is true, line 28 describes an if statement in the condition where if the player is on the ground and pressing space, and line 32 describes the bool member variable IsGrounded to equal false. All together, the lines might mean that when the player presses the Space key and is on the ground, the player will jump, causing it to not be on the ground.


1. Only the Goal gameObject has Is Trigger checked because it doesn't need to move around since it would be triggered when something collides with it. The Cat and SoccerBall gameObjects will need to have Rigidbodies because they have to be moving around and colliding with each other to collide with the Goal gameObject to receive points.
2. The Cat gameObject was slightly off the ground when I ran the game, but I figured out that the Capsule Collider was slightly beneath the ground, which meant that there would be an "invisible" part of the cat that lifted it slightly and collided with the ground.

### W5

In what situation would we need to put code in the parentheses of GetComponent();?
You would need to fill in the parentheses with the type parameter if you want to specify the type of component that you want to retrieve.

We will need a Navmesh member varaible and the target member variable. The methods we would need would be the Start() method because the deer has to check and set the target at the beginning of the game, which includes getting the Navmesh component so the deer can navigate towards the target.

### W6

I added resources for the General C# Coding category. [Google Doc Group #11 Outline GDIM 31 Topics](https://docs.google.com/document/d/1jGkW1Q2xP_713KL3rIzM0yPQ_F7CGMHJ1AHQlTPs5pg/edit?tab=t.0)

Pair Programming Notes:
This class needs bool member variable to check if the bats are moving and a float member variable for the speed of the bats, and the Start() and Update() method to make the bats start chasing the player as the game begins and update the current distance between the bats and the player. The Update() method will also be used to make the bat stop chasing the player and a new bat to start chasing it.

### W7

https://docs.google.com/document/d/1tP76vpdvqVFgg7NrHrj0tOCw1tf_d0Ft6UOzOWAW50Q/edit?usp=sharing

The error in Step two was that the code used transform.position, which is for world space, but it should be for local so that the muskrat gameObject can actually move relative to itself, which means that the code would have to use transform.Translate();.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
