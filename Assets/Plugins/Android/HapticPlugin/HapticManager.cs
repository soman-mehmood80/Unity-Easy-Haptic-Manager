//https://github.com/MahdiRahmatii/Unity-Easy-Haptic-Manager
using System;
using UnityEngine;

public static class HapticManager
{
#if UNITY_ANDROID && !UNITY_EDITOR
    private static AndroidJavaObject _plugin;
#endif

	/// <summary>
	/// Initializes the haptic feedback system for Android devices.
	/// </summary>
	/// <remarks>This method sets up the necessary Android Java objects to enable haptic feedback functionality when
	/// running on an Android device. It should be called before attempting to use any haptic features. This method has no
	/// effect when running in the Unity Editor or on non-Android platforms.</remarks>
	public static void Initialize()
	{
#if UNITY_ANDROID && !UNITY_EDITOR
        using var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        var context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        using var pluginClass = new AndroidJavaClass("com.yourcompany.haptic.HapticManager");
        pluginClass.CallStatic("init", context);
#endif
	}

	/// <summary>
	/// Triggers a simple vibration on the device at the specified haptic level.
	/// </summary>
	/// <remarks>On Android devices, this method uses a platform-specific implementation to trigger the vibration. 
	/// On other platforms, it falls back to a default vibration method.</remarks>
	/// <param name="level">The intensity level of the vibration. This parameter determines the strength of the haptic feedback.</param>
	public static void SimpleVibrate(HapticLevel level)
	{
#if UNITY_ANDROID && !UNITY_EDITOR
        using var pluginClass = new AndroidJavaClass("com.yourcompany.haptic.HapticManager");
        pluginClass.CallStatic("simpleVibrate", (int)level);
#else
		Handheld.Vibrate(); // fallback
		Debug.Log($"[SimpleVibrate] -> HapticLevel: {level}");
#endif
	}

	/// <summary>
	/// Initiates a custom vibration on supported Android devices with specified duration and amplitude.
	/// </summary>
	/// <remarks>On non-Android platforms or when running in the Unity Editor, this method falls back to a default
	/// vibration and logs the parameters.</remarks>
	/// <param name="duration">The duration of the vibration in milliseconds. Must be a positive value.</param>
	/// <param name="amplitude">The intensity of the vibration, ranging from 1 to 255. Higher values indicate stronger vibrations.</param>
	public static void CustomVibrate(long duration, int amplitude) // Duration (ms), Amplitude (1–255)
	{
#if UNITY_ANDROID && !UNITY_EDITOR
        using var pluginClass = new AndroidJavaClass("com.yourcompany.haptic.HapticManager");
        pluginClass.CallStatic("customVibrate", (long)duration, (int)amplitude);
#else
		Handheld.Vibrate(); // fallback
		Debug.Log($"[CustomVibrate] -> Duration: {duration} , Amplitude: {amplitude}");
#endif
	}

	/// <summary>
	/// Stops the haptic feedback on Android devices.
	/// </summary>
	/// <remarks>This method is effective only on Android devices and has no effect when called from the Unity
	/// Editor.</remarks>
	public static void Stop()
	{
#if UNITY_ANDROID && !UNITY_EDITOR
        using var pluginClass = new AndroidJavaClass("com.yourcompany.haptic.HapticManager");
        pluginClass.CallStatic("stop");
#endif
	}
}

public enum HapticLevel
{
	VeryLight = 1,
	Light = 2,
	Medium = 3,
	Heavy = 4,
	Extreme = 5
}