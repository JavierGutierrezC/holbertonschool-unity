# 0x09. Unity - AR Business Card

# Tasks

## 0. Let's see Paul Allen's card 
In this project, you will create a business card for yourself with an AR-identifiable printed marker. You can use the following image or create your own. If you create your own, you must upload it in the form below.
Create a static layout for the business card in a Unity scene called ```ARBusinessCard```. We strongly suggest you sketch out your business card layout (as well as storyboarding its subsequent animation for task #2) before opening up Unity. Your layout must include:

* your name
* job title
* at least four links, in text or button form
  * email
  * website / github
  * twitter
  * linkedin
  * or any other link or social media you want to use to promote yourself
          
## 1. Target acquired
Set up a target image database in Vuforia’s Target Manager and set up your AR marker such that your business card layout appears when your device’s camera detects the marker.

The layout should be anchored to the marker and the layout’s transform values should change depending on the marker’s angle, pose, and distance in relation to the device’s camera. If the marker is not visible, all elements of the business card should disappear.

## 2. Animated reality 
Add animations to your layout. The design and feel of the experience is up to you but keep in mind the overall user experience (text should be legible, buttons should be large enough to press individually, etc.)

Be dynamic and play to the strengths of the AR medium — animation is key!

## 3. Social link up
cript the links to be interactive. When they are pressed on the device screen, they should open the associated link or app. The buttons should also give some kind of visual or audible feedback when pressed, such as the button changing color or a sound like a beep or click. Keep in mind accessibility guidelines in your UI/UX decisions!

## 4. Building cards 
**Scenes in Build:**

ARBusinessCard
Create two ```builds``` of the business card scene in the Builds directory.

**Build Folder Hierarchy:**

* Builds
  * iOS
    * Build files
  * Android
    * ARBusinessCard.apk


## Author

Javier Gutierrez  | [https://github.com/JavierGutierrezC](https://github.com/JavierGutierrezC)