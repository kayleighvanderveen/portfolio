using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopNitrogen : MonoBehaviour {

    public SpriteRenderer sr;
    public Slider UITimer;
    public GameObject Winpanel;
    public GameObject Losepanel;
    public GameObject AnimationBad;
    public GameObject AnimationGood;
    public float totalTime;

    private float timeLeft = 0f;
    private bool NitrogenFlowing;

    // All panels not active before the scene starts
    public void Awake() {
        Losepanel.gameObject.SetActive(false);
        Winpanel.gameObject.SetActive(false);
        AnimationBad.gameObject.SetActive(false);
        AnimationGood.gameObject.SetActive(false);
    }

    public void Start() {
        UITimer.maxValue = totalTime;
    }

    public void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;

        Debug.Log(NitrogenFlowing);

        // If time is up and nitrogen is active - start bad animation
        if (totalTime <= timeLeft && NitrogenFlowing == true) {
            Debug.Log("Slechte animatie");
            AnimationBad.gameObject.SetActive(true);
            // After 3 seconds of animation, show lose panel
            if (totalTime <= -3) {
                Losepanel.gameObject.SetActive(true);
            }
        }
        // If time is up and nitrogen is not active - start win panel
        if (totalTime <= timeLeft && NitrogenFlowing == false) {
            Debug.Log("Goede animatie");
            AnimationGood.gameObject.SetActive(true);

            if (totalTime <= -3) {
                Winpanel.gameObject.SetActive(true);

            }
        }
        // To prevent both panels to show up
        if (Winpanel.activeSelf == true) {
            Losepanel.gameObject.SetActive(false);
        }

        if (Losepanel.activeSelf == true) {
            Winpanel.gameObject.SetActive(false);
        }
    }
   
    // Touch screen - nitrogen will disappear
    private void OnMouseDown() {
        sr.color = new Color(1f, 1f, 1f, 0f);
        NitrogenFlowing = false;
    }

    // Dont touch screen - nitrogen will appear
    private void OnMouseUp() {
        sr.color = new Color(1f, 1f, 1f, 1f);
        NitrogenFlowing = true;
    }

    /* 
    private bool NitrogenOFF() {
        sr.color = new Color(1f, 1f, 1f, 0f);
        return false;
    }

    private bool NitrogenON() {
        sr.color = new Color(1f, 1f, 1f, 1f);
        return true;
    }*/
}
