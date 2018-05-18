using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleCollide : MonoBehaviour {
    DragOnTouch dragScript;
    public Slider UITimer;
    public GameObject Losepanel;
    public GameObject Winpanel;
    public GameObject AnimationGood;
    public GameObject AnimationBad;
    public float totalTime;

    public bool won = false;

    private float timeLeft = 0f;

    public void Awake() {
        Winpanel.gameObject.SetActive(false);
        Losepanel.gameObject.SetActive(false);
        AnimationGood.gameObject.SetActive(false);
        AnimationBad.gameObject.SetActive(false);
    }

    private void Start() {
        dragScript = GetComponent<DragOnTouch>();
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

        if (Winpanel.activeSelf == true) {
            Losepanel.gameObject.SetActive(false);
        }

        if (Losepanel.activeSelf == true) {
            Winpanel.gameObject.SetActive(false);
        }

        if (totalTime <= -3 && won) {
            Winpanel.gameObject.SetActive(true);
        }

        if (totalTime <= -3 && !won) {
            Losepanel.gameObject.SetActive(true);
        }

    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Trash" && dragScript.isLose) {
            AnimationGood.gameObject.SetActive(true);
            won = true;


        } else if (other.gameObject.tag == "Water" && dragScript.isLose) {
            won = false;
            AnimationBad.gameObject.SetActive(true);
            Lose();

        }
    }

    public void Win() {
        
    }

    public void Lose() {
        
    }
}
