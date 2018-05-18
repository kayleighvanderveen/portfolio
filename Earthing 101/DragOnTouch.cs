using UnityEngine;
using System.Collections;

public class DragOnTouch: MonoBehaviour {
    Camera cam;
    // Update is called once per frame
    public float speed = 0.1F;
    public bool isLose = false;

    public void Start() {
        cam = Camera.main;
    }
    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.touches[0];
            transform.position = (Vector2)cam.ScreenToWorldPoint(touch.position);
            //transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
            switch (touch.phase){
                case TouchPhase.Ended:
                    isLose = true;
                    break;
            }
        }
    }
}