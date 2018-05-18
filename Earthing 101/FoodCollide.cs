using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollide : MonoBehaviour {

    DragOnTouch dragScript;
    public GameObject Winpanel;
    public GameObject Losepanel;

    public void Awake() {
        Winpanel.gameObject.SetActive(false);
        Losepanel.gameObject.SetActive(false);
    }

    private void Start() {
        dragScript = GetComponent<DragOnTouch>();
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Banaan" && dragScript.isLose) {
            Winpanel.gameObject.SetActive(true);
        } else if (other.gameObject.tag == "Ham" && dragScript.isLose) {
            Losepanel.gameObject.SetActive(true);
        }
    }
}
