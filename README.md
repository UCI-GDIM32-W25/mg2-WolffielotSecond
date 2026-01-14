[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

First I planned 4 things, the bird, the coin, the game controller and the UI. Then I created basic things that satisfies the 4 catagories: the player character, the bird; a prefab for the coin; the game controller/ player manager game object; and the canvas for the UI.

Second, I created scripts for the player, coin and game controller. The coin one is rather simple, it only manages it's leftward movement, by using transform.translate a speed multiplied by the directional vector and delta time. The player manages jumping and on collision enter(OnCollisionEnter2D), which is for the ground detection to reset whether or not the player can jump, and on component begin overlap(OnTriggerEnter2D), which detects whether to eat a coin. The game controller manages the UI and updates it when the player eats a coin.

In the mean time, to make the collision system work, the ground needs to be tagged with 'ground' and the coin 'coin'. And a rigid body needs to be assigned in the player to let the bird fall. The coins needs to be set to 'is trigger' to let the on overlap function be effective.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
