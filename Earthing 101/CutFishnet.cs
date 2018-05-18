using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFishnet : MonoBehaviour {

    Camera cam;
    public Vector2 startPos;
    public bool couldBeSwipe;
    public bool swiped;
    public bool lose = false;
    public float comfortZone;
    public float minSwipeDist = 10f;
    public float maxSwipeTime;
    public float startTime;
    public GameObject winPanel;
    public GameObject losePanel;

    private float swipeTime;
    private float swipeDist;

    private bool visnet1 = false;
    private bool visnet2 = false;
    private bool hitFish = false;

    public void Start() {
        cam = Camera.main;
    }

    public void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.touches[0];
            transform.position = cam.ScreenToWorldPoint(touch.position);

            switch (touch.phase) {
                case TouchPhase.Began:
                    couldBeSwipe = true;
                    startPos = touch.position;
                    startTime = Time.time;
                    break;

                case TouchPhase.Moved:
                    if (Mathf.Abs(touch.position.x - startPos.x) > comfortZone) {
                        couldBeSwipe = false;
                    }
                    break;

                case TouchPhase.Ended:
                    float swipeTime = Time.time - startTime;
                    float swipeDist = (touch.position - startPos).magnitude;

                    if (couldBeSwipe && swipeTime < maxSwipeTime && swipeDist > minSwipeDist) {
                        swiped = true;
                    } else {
                        couldBeSwipe = false;
                    }
                    break;
            }
        }

        if (visnet1 && visnet2 && !hitFish) {
            lose = true;
        }
    }

    public void ResetSwipe() {
        couldBeSwipe = false;
        swiped = true;
    }

    // When collide, deactive the fishnet and win this scene
    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Visnet") {
            visnet1 = true;
            Debug.Log("visnet1: " + visnet1);
        }
        if (collision.gameObject.tag == "Visnet2") {
            visnet2 = true;
            Debug.Log("visnet2: " + visnet2);
        }
        if (collision.gameObject.tag == "Vis") {
            Debug.Log("vis geraakt");
            lose = false;
        }
    }
}
