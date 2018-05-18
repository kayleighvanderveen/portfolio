using UnityEngine;
using System.Collections;

public class VolumeController : MonoBehaviour {

    private float currentVolume;

	public void VolumeControl(float volumeControl) {
        GetComponent<AudioSource>().volume = currentVolume;
    }
}
