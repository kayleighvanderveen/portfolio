using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    //Pause Menu Image
    public Transform image;

    public void Update() {
        //Press Escape Key to activate pause menu
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (image.gameObject.activeInHierarchy == false) {
                image.gameObject.SetActive(true);
                Time.timeScale = 0;
                AudioListener.volume = 0;
            } else {
                image.gameObject.SetActive(false);
                Time.timeScale = 1;
                AudioListener.volume = 1;
            }

        }

    }
}
