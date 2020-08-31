# 0x0B. Unity - VR Room

# Tasks

## 0. You ever wonder why we're here  
In this project, you will be creating a sitting / standing VR experience in the form of a simple exploration (mandatory tasks) or ```“escape room”```-style ```game``` (advanced tasks).
          
## 1. Primitive prototype 
Implement the “teleportation” method of movement so that the user can use the controller to indicate where they want to move and move there on button press.

* The user should not be able to teleport outside the boundaries of the room or into other objects, i.e. they cannot pass through colliders
* The user should not be able to teleport through the closed door
* Give the user visual feedback that indicates where they are teleporting to
* Make sure to reduce chances of motion sickness in your implementation of the teleportation
* Even if you are developing for a 6DOF headset, you should still implement a method of teleportation to account for different play area sizes

## 2. Object oriented 
Create interaction that allows an object to be picked up and/or interacted with by the controller(s). How you implement the interaction may be determined by the VR headset / controller you are targeting, but always keep the user in mind and make their experience as smooth and intuitive as possible.

## 3. Let the right one in
Script interaction in the scene so that the door opens with an animation when the user interacts with it.

* The door should animate when it opens (the animation is included in the files you downloaded) and the player can then pass through the doorway
* The boundaries of the room (walls, floors, ceilings, windows) cannot be moved, edited, or changed in any way
* You may add new GameObjects to the room (more props / 3D models, UI, animation, etc.) but you cannot remove any existing GameObjects
* You may add and edit materials and textures

## 4. An "on" button would have sufficed
Script interaction in the scene so that the projector in the center of the second room turns on when the user interacts with it.

## 5. We didn't really escape though
**Scenes in Build:**

1.```<Scene Name>```

Create a build of the tour in a ```Builds``` directory and name it based on your targeted device (ex. ```VR_Room_<TargetHeadsetName>``` -> ```VR_Room_OculusGo```).

**Build Folder Hierarchy:**

* Builds
    * [Target Device]
        * [Associated Build Files]



## Author

Javier Gutierrez  | [https://github.com/JavierGutierrezC](https://github.com/JavierGutierrezC)