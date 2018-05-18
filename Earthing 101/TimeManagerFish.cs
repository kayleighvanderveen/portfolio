using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagerFish : MonoBehaviour {

    public Slider UITimer;
    public GameObject Winpanel;
    public GameObject Losepanel;
    public GameObject swipe;
    public CutFishnet swipeScript;
    public GameObject AnimationGood;
    public GameObject AnimationBad;

    public float totalTime;
    private float timeLeft = 0f;

    void Awake() {
        Winpanel.gameObject.SetActive(false);
        Losepanel.gameObject.SetActive(false);
        AnimationGood.gameObject.SetActive(false);
        AnimationBad.gameObject.SetActive(false);
    }

    void Start() {
        UITimer.maxValue = totalTime;
        swipeScript = swipe.GetComponent<CutFishnet>();
    }

    void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;

        if (totalTime <= timeLeft && !swipeScript.lose) {
            AnimationBad.gameObject.SetActive(true);

            if (totalTime <= -3) {
                Losepanel.gameObject.SetActive(true);
            }
        } 

        else if (totalTime <= timeLeft && swipeScript.lose) {
            AnimationGood.gameObject.SetActive(true);

            if (totalTime <= -3) {
                Winpanel.gameObject.SetActive(true);
            }
        }

        if (Winpanel.activeSelf == true) {
            Losepanel.gameObject.SetActive(false);
        }

        if (Losepanel.activeSelf == true) {
            Winpanel.gameObject.SetActive(false);
        }
    }
}
