using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeOnTree : MonoBehaviour {
    Camera cam;
    public float startTime;
    public Vector2 startPos;
    public bool couldBeSwipe;
    public bool swiped;
    public float comfortZone;
    public float minSwipeDist = 10f;
    public float maxSwipeTime;
    private float swipeTime;
    private float swipeDist;

    public GameObject winPanel;
    public GameObject losePanel;
    public bool lose = false;

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
    }

    public void ResetSwipe() {
        couldBeSwipe = false;
        swiped = true;
    }


    public void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Tree") {
            collision.gameObject.SetActive(false);
            lose = true;
        }
    }

}
