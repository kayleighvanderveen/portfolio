﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishToNext : MonoBehaviour {

    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
