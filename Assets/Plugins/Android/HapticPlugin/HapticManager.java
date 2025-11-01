//https://github.com/MahdiRahmatii/Unity-Easy-Haptic-Manager
package com.yourcompany.haptic;

import android.content.Context;
import android.os.Build;
import android.os.VibrationEffect;
import android.os.Vibrator;
import android.os.VibratorManager;

public class HapticManager {

    private static Vibrator vibrator;

    public static void init(Context context) {
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.S) {
            VibratorManager vm = (VibratorManager) context.getSystemService(Context.VIBRATOR_MANAGER_SERVICE);
            vibrator = vm.getDefaultVibrator();
        } else {
            vibrator = (Vibrator) context.getSystemService(Context.VIBRATOR_SERVICE);
        }
    }

    public static void simpleVibrate(int level) {
        long duration = 15;
        int amplitude = VibrationEffect.DEFAULT_AMPLITUDE;

        switch (level) {
            case 1: // VeryLight
                duration = 15;
                amplitude = 40;
                break;
            case 2: // Light
                duration = 25;
                amplitude = 80;
                break;
            case 3: // Medium
                duration = 40;
                amplitude = 150;
                break;
            case 4: // Heavy
                duration = 70;
                amplitude = 220;
                break;
            case 5: // Extreme
                duration = 100;
                amplitude = 255;
                break;
        }

        customVibrate(duration, amplitude);
    }

    public static void customVibrate(long duration, int amplitude)
    {
        if (vibrator == null) return;

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            vibrator.vibrate(VibrationEffect.createOneShot(duration, amplitude));
        } else {
            vibrator.vibrate(duration);
        }
    }

    public static void stop() {
        if (vibrator != null) vibrator.cancel();
    }
}