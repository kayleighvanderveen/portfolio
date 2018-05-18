using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagerPlasticSoup : MonoBehaviour {

    public Slider UITimer;
    public GameObject Losepanel;
    public GameObject Winpanel;
    public float totalTime;

    private float timeLeft = 0f;

    void Awake() {
        Losepanel.gameObject.SetActive(false);
    }

    void Start() {
        UITimer.maxValue = totalTime;
    }

    void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;
        // If time is up and plastic is still in the scene, lose panel is active
        if (totalTime <= timeLeft && (GameObject.FindGameObjectsWithTag("Trash").Length > 0)) {
            Losepanel.gameObject.SetActive(true);
        }

        // If all plastic is gone, win panel is active
        if (GameObject.FindGameObjectsWithTag("Trash").Length == 0) {
            Winpanel.gameObject.SetActive(true);
            }
    }
}