using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    private bool isFalling = false;
    private float downSpeed = 0;

    private void Update() {
        if (isFalling) {
            downSpeed += Time.deltaTime / 30;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isFalling = true;
            Destroy(gameObject, 10);
        }
    }
}
