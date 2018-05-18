using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateMolen : MonoBehaviour { 

    public Slider UITimer;
    public GameObject Losepanel;
    public GameObject Winpanel;
    public float totalTime;

    private float timeLeft = 0f;
    private float pointerY;
    private float f_lastX = 0.0f;
    private float f_difX = 0.5f;
    private float f_steps = 0.0f;
    private int i_direction = 1;
    private bool rotation;

    public void Awake() {
        Losepanel.gameObject.SetActive(false);
        Winpanel.gameObject.SetActive(false);
    }

    public void Start() {
        pointerY = Input.GetAxis("Mouse Y");
        UITimer.maxValue = totalTime;
    }

    public void Update() {
        UITimer.value = totalTime;
        totalTime -= Time.deltaTime;
        UITimer.value = totalTime;

        Debug.Log(rotation);

        // Rotate the image
        if (Input.GetMouseButtonDown(0)) {
            f_difX = 0.0f;
            rotation = false;
        } 

        else if (Input.touchCount > 0) {
            pointerY = Input.touches[0].deltaPosition.y;
            f_difX = Mathf.Abs(f_lastX - pointerY);
            var touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2) {
                rotation = true;

                // Rotate to the right
                if (f_lastX < Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    transform.Rotate(Vector3.forward, f_difX * Time.deltaTime);
                }
                if (f_lastX > Input.GetAxis("Mouse Y")) {
                    i_direction = -1;
                    transform.Rotate(Vector3.forward, -f_difX * Time.deltaTime);
                }
            } 
            
            else if (touch.position.x < Screen.width / 2) {
                rotation = true;

                // Rotate to the left
                if (f_lastX < Input.GetAxis("Mouse Y")) {
                    i_direction = -1;
                    transform.Rotate(Vector3.forward, -f_difX * Time.deltaTime);
                }
                if (f_lastX > Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    transform.Rotate(Vector3.forward, f_difX * Time.deltaTime);
                }
            }

            f_lastX = -pointerY;
            f_difX = 500f;
            //Debug.Log(f_difX);
        } 
        
        else {
            if (f_difX > 0.5f) f_difX -= 1f;
            if (f_difX < 0.5f) f_difX += 1f;
            transform.Rotate(Vector3.forward, f_difX * i_direction * Time.smoothDeltaTime);
        }

        if (totalTime <= timeLeft && rotation == false) {
            Losepanel.gameObject.SetActive(true);
        }

        if (totalTime <= timeLeft && rotation == true) {
            Winpanel.gameObject.SetActive(true);
        }

        if (Winpanel.activeSelf == true) {
            Losepanel.gameObject.SetActive(false);
        }

        if (Losepanel.activeSelf == true) {
            Winpanel.gameObject.SetActive(false);
        }
    }
}