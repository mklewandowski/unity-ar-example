# unity-ar-example

A small example of AR integration in Unity using AR Foundation. Using this application, 1 of 20 randomly chosen food items can be placed using a placement cursor in an AR scene. This project is built using Unity version 2020.3.10f1 and is designed to run on Android devices (not tested in iOS). 

## Supported Platforms
This project is designed for use on both iOS and Android, but it has only been tested on Android.

## Running locally
Use the following steps to run locally:
1. Clone this repo
2. Open repo folder using Unity 2020.3.10f.1

## Development
Some required and useful modifications (not mentioned in tutorial):
- Set Minimum API Level to Android API level 24 or higher (this is required to build for Android)
- Remove Vulkan from Graphics APIs (this is required to build for Android)
- Disable Render Outside Safe Space 
- Disable Start in Fullscreen Mode

## Development Tools
- Created using Unity 2020.3.10f.1
- Code edited using Visual Studio Code

## Credits
Code and scene structure is based on this tutorial:
https://www.youtube.com/watch?v=R3OCUE9TwZk
