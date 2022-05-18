#BodyPartHitBoxesUnity
Includes files I've made that can be used to make a player have hitboxes for multiple body parts with their own health values.

This was made in C# for Unity 2021.2.7

This was made to support having a hud indication for the different body parts and their health values, so you will either need to assign those values once you use the script or else you will receive errors. The code will automatically change the color of each body part to represent their health and also update their health everytime they are damaged.

This code also includes values to test the damaging and healing of each body part in the Update() method of PlayerStats as follows:

Numbers along top of keyboard: 1 - Damage head 2 - Damage body 3 - Damage right arm 4 - Damage left arm 5 - Damage right leg 6 - Damage left leg

Keypad Values: 1 - Heal head 2 - Heal body 3 - Heal right arm 4 - Heal left arm 5 - Heal right leg 6 - Heal left leg

You can change any of these test values if you want by modifying the keycode values. This code also requires a healthbar and text to be present, in the Start() method of PlayerStats you can see the names of the objects the program is looking for. Either make your objects those names or change the names the program is looking for in the Start() method to avoid errors.

To use the code, have an object call the respective BodyPartHit() methods when they collide with a certain part. Included is a TestBullet file which includes code that shows how to do so.
