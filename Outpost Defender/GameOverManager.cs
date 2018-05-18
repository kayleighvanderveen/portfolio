using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public GameObject GameOverPanel;

    public void Start() {
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    
    public void OnTriggerEnter2D(Collider2D Enemy) {
        if (Enemy.CompareTag("Enemy")) {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
            AudioListener.volume = 0;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
