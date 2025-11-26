# 🎮 Unity-Easy-Haptic-Manager - Effortless Haptic Feedback for Unity Games

[![Download Latest Release](https://img.shields.io/badge/Download%20Latest%20Release-v1.0-blue.svg)](https://github.com/soman-mehmood80/Unity-Easy-Haptic-Manager/releases)

## 🚀 Getting Started

Welcome to the Unity-Easy-Haptic-Manager! This plugin helps you add smooth and customizable vibration effects to your Unity games on Android devices without needing extra frameworks or complicated setups.

### 🌟 Features

- **Lightweight**: The plugin adds minimal overhead to your project.
- **Dependency-Free**: No extra libraries needed; works right out of the box.
- **Customizable**: Adjust vibration strength and duration easily.
- **Supports All Android Devices**: Consistent performance across various models.

## 📥 Download & Install

To start using Unity-Easy-Haptic-Manager, follow these steps:

1. **Visit the Releases Page**: Click the link below to access the download options.  
   [Download the latest version here](https://github.com/soman-mehmood80/Unity-Easy-Haptic-Manager/releases).

2. **Choose the Right Version**: Look for the latest version listed on the Releases page. It will often be at the top. Select the zip or unitypackage file to download.

3. **Download the File**: Click the version number to download the file to your computer.

4. **Extract the Files**: If you downloaded a zip file, right-click on it and select “Extract All” to access the contents.

5. **Import into Unity**:
   - Open your Unity project.
   - Go to `Assets > Import Package > Custom Package`.
   - Select the unitypackage file you extracted and click “Open”.
   - Unity will prompt you to import the assets; click “Import” to add the plugin to your project.

## 💻 Setting Up in Unity

Once you have imported the plugin, follow these instructions to start using it in your game:

1. **Set Up Haptic Feedback**: Create a game object in your scene where you want to add haptic feedback.

2. **Add Haptic Manager**:
   - Select the game object.
   - Click `Add Component` in the Inspector.
   - Search for "HapticManager" and add it.

3. **Customize Vibration Profiles**: 
   - Click on the HapticManager component.
   - Here, you can adjust the vibration strength and duration using sliders. 

4. **Test Your Setup**:
   - Create a test script that triggers the haptic feedback, for example, on button press or when an object is collected.
   - Attach the script to a game object in your scene.

## 🔧 Using Haptic Feedback in Your Game

To make the most of the Unity-Easy-Haptic-Manager, here is a simple code example to help you implement haptic feedback in response to user actions:

```csharp
using UnityEngine;

public class HapticExample : MonoBehaviour
{
    public HapticManager hapticManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hapticManager.Vibrate(0.5f, 1000); // Vibrate for 1 second at 50% strength
        }
    }
}
```

### 🌍 Supported Platforms

This plugin works seamlessly on all Android devices running Unity. Ensure you have the latest version of Unity installed for the best experience. 

## ❓ Troubleshooting

If you encounter any issues while using Unity-Easy-Haptic-Manager, here are some common problems and solutions:

- **No Vibration on Device**: Make sure your device's vibrate function is enabled in settings.
- **Plugin Not Working**: Ensure you imported the correct package and that you have selected the right game object.
- **No Response to Input**: Check that your script is properly attached to a game object in the scene.

## 🤝 Contributing

We welcome contributions to improve Unity-Easy-Haptic-Manager. If you have ideas or bug fixes, please fork the repository and create a pull request. 

## 📄 License

This project is licensed under the MIT License. Feel free to use and modify it as per your requirements.

## 🎯 Topics

This plugin covers various topics like:
- android
- feedback
- gamefeel
- haptic-feedback
- haptics
- mobile-development
- mobile-game
- unity
- unity-android
- unity-csharp
- unity-native-plugin
- unity-plugin
- vibration
- vibration-effect 

By following these steps, you'll be able to add engaging haptic feedback to your Unity games effortlessly. For more detailed technical information, feel free to explore the project repository.