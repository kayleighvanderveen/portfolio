using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTrees2 : MonoBehaviour {

    public Slider UITimer;
    public GameObject Winpanel;
    public GameObject Losepanel;
    public GameObject swipe;
    public SwipeOnTree swipeScript;
    public GameObject AnimationGood;
    public GameObject AnimationBad;

    public float totalTime;
    private float timeLeft = 0f;

    void Start() {
        UITimer.maxValue = totalTime;
        swipeScript = swipe.GetComponent<SwipeOnTree>();
    }

    void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;

        if (totalTime <= timeLeft && swipeScript.lose) {
            AnimationGood.gameObject.SetActive(true);

            if (totalTime <= -3) {
                Winpanel.gameObject.SetActive(true);
            }

        } else if (totalTime <= timeLeft && !swipeScript.lose) {
            AnimationGood.gameObject.SetActive(true);

            if (totalTime <= -3) {
                //Debug.Log(totalTime + "Total time");
                Losepanel.gameObject.SetActive(true);
            }
        }
    }
}