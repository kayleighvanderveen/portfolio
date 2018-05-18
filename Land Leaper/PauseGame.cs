using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public Transform image;
    
	void Update () {
        if (Input.GetKey(KeyCode.Escape)) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (image.gameObject.activeInHierarchy == false) {
                    image.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    AudioListener.volume = 0;
                } 
                else {
                    image.gameObject.SetActive(false);
                    Time.timeScale = 1;
                    AudioListener.volume = 1;
                }
            } 
            else if (Input.GetKeyUp(KeyCode.Escape)) {
                image.gameObject.SetActive(false);
                Time.timeScale = 1;
                AudioListener.volume = 1;
            }
        }
	}
}
