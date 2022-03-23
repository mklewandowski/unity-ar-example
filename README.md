# unity-ar-example

A small example of AR integration in Unity using AR Foundation. Using this application, 1 of 20 randomly chosen food items can be placed using a placement cursor in an AR scene. This project is built using Unity version 2020.3.10f1 and is designed to run on Android devices (not tested in iOS). 

## Credits
Code and scene structure is based on this tutorial:
https://www.youtube.com/watch?v=R3OCUE9TwZk

## Development
Some required and useful modifications (not mentioned in tutorial):
- Set Minimum API Level to Android API level 24 or higher (this is required to build for Android)
- Remove Vulkan from Graphics APIs (this is required to build for Android)
- Disable Render Outside Safe Space 
- Disable Start in Fullscreen Mode