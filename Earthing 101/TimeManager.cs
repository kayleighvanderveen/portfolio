using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Slider UITimer;
    public GameObject Losepanel;
    public GameObject AnimationGood;
    public GameObject AnimationBad;
    public float totalTime;

    private float timeLeft = 0f;

    public void Awake() {
        Losepanel.gameObject.SetActive(false);
    }

    public void Start() {
        UITimer.maxValue = totalTime;
    }

    public void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;
        if (totalTime <= timeLeft) {
            AnimationBad.gameObject.SetActive(true);

            if (totalTime <= -3) {
                Losepanel.gameObject.SetActive(true);
            }
        }
    }
}
