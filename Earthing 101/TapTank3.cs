using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class TapTank3 : MonoBehaviour {

    public GameObject Olie;
    public GameObject Winpanel;

    private float holdTime = 0.8f;
    private float acumTime = 0;

    void Start() {
    }

    void Update() {

        for (int i = 0; i < Input.touchCount; i++) {
            //Do something with the touches
            if (Input.touchCount >= 5) {
                Destroy(gameObject);
                Winpanel.gameObject.SetActive(true);
            }
        }
    }
}

