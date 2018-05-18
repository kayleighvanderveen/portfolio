using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour {

    public static WinManager instance = null;
    public float resetDelay;
    public GameObject WinText;

    private void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

    public void Win() {
        WinText.SetActive(true);
        Time.timeScale = .5f;
        Invoke("Reset", resetDelay);
    }

    private void Reset() { 
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("StartMenu");
    }
}
