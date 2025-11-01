using UnityEngine;

public class HapticTest : MonoBehaviour
{
	//Initialize
	private void Start() => HapticManager.Initialize();

	//Stop Haptic
	public void Stop() => HapticManager.Stop();

	//Simple Haptic (1 to 5)
	public void SimpleVibrate(int level) => HapticManager.SimpleVibrate((HapticLevel)level);

	//Custom Haptic
	private string durationField, amplitudeField;
	public void SetDuration(string value) => durationField = value;
	public void SetAmplitude(string value) => amplitudeField = value;

	public void CustomVibrate()
	{
		if (long.TryParse(durationField, out long duration) &&
			int.TryParse(amplitudeField, out int amplitude))
			HapticManager.CustomVibrate(duration, amplitude);
	}
}