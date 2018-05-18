using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

    public GameObject NextWavePanel;

    public float timer = 0f;

    private void Awake() {
        // Set panel to false
        NextWavePanel.SetActive(false);
    }

    public void Update() {

        /*// if there is no enemy in the scene, end wave and activate panel
        if (GameObject.FindWithTag("Enemy") == null) {
            NextWavePanel.SetActive(true);
            timer += 1;
            //WaveTimer();
        }*/
    }

    /*public void WaveTimer() {
        if (timer >= 20) {
        } 
    }*/
}