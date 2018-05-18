using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class TapTank : MonoBehaviour {

    public GameObject Olie1;
    public GameObject Winpanel;

    private float holdTime = 0.8f; 
    private float acumTime = 0;

    void Start() {
    }

    void Update() {

        for (int i = 0; i < Input.touchCount; i++) {
            //Do something with the touches
            if (Input.touchCount >= 3) {
                Destroy(gameObject);
                Winpanel.gameObject.SetActive(true);
            }
    }



        /*if ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began)) {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit raycastHit;

            if (Physics.Raycast(raycast, out raycastHit)) {
                Debug.Log("Something happened");
                if (raycastHit.collider.CompareTag("Olie")) {
                    Debug.Log("Olie cliked");
                }
            }
        }*/

        /*if (Input.touchCount > 0) {
            acumTime += Input.GetTouch(0).deltaTime;

            if (acumTime >= holdTime) {
                //Long tap
                gameObject.SetActive(false);
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended) {
                acumTime = 0;
            }
        }*/
    }
}
