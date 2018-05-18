using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour {

    private PlayerHealth player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Player")) {
            player.TakeDamage(3);
        }
    }
}
