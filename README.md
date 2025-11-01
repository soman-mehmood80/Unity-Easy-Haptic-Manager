# Unity Easy Haptic Manager (Android)

A lightweight and consistent **Haptic feedback plugin for Unity (Android)**.  
It gives you precise vibration control across all Android devices — from older phones to the latest Android 14+ models.

---

## 🚀 Features

- ✅ Simple API — just one line to trigger vibration.
- ✅ Works on **all Android devices (API 21+)**
- ✅ Uses `VibratorManager` automatically on Android 12+ (multi-motor support)
- ✅ Supports **custom vibration duration and amplitude**
- ✅ Provides **5 adjustable haptic levels** — from subtle taps to strong impacts
- ✅ Safe fallback (`Handheld.Vibrate`) in Editor or non-Android builds
- ✅ Requires only a single line to initialize

---

## 📦 Installation

1. **Clone or download** this repository.  
2. Copy the following folders into your Unity project:
3. Ensure your Android Manifest includes: <em>(This is already included if you use the provided manifest in /Plugins/Android/..)</em>
```xml
<uses-permission android:name="android.permission.VIBRATE" />
```
4. Build your project for Android. That’s it — no Gradle or Java configuration needed.

---

# 🧠 Usage

1️⃣ Initialize (required once)

Call this early, like in your game’s startup scene:
```
void Start() => HapticManager.Initialize();
```

2️⃣ <strong>Simple Vibrate</strong>: predefined haptic levels
```
1. HapticManager.SimpleVibrate(HapticLevel.Light);
2. HapticManager.SimpleVibrate(HapticLevel.Medium);
3. HapticManager.SimpleVibrate(HapticLevel.Heavy);
4. HapticManager.SimpleVibrate(HapticLevel.Strong);
5. HapticManager.SimpleVibrate(HapticLevel.ExtraStrong);
```

3️⃣ <strong>Custom Vibrate</strong>: define your own vibration
```
HapticManager.CustomVibrate(duration: 80, amplitude: 200); // Duration (ms), Amplitude (1–255)
```

4️⃣ Stop ongoing vibration
```
HapticManager.Stop();
```

🎛️ Simple Haptic Levels
| Level | Name      | Duration (ms) | Amplitude |
| ----- | --------- | ------------- | --------- |
| 1     | VeryLight | 15            | 40        |
| 2     | Light     | 25            | 80        |
| 3     | Medium    | 40            | 150       |
| 4     | Heavy     | 70            | 220       |
| 5     | Extreme   | 100           | 255       |

---

## 🎮 Demo Scene

A sample scene is included at:

```
Assets\Plugins\Android\HapticPlugin\Demo\...
```
It provides UI buttons to test each Haptic Level and verify everything is working properly on your Android device.

---

⭐ If this plugin helps your project, consider giving it a star on GitHub! 🙏