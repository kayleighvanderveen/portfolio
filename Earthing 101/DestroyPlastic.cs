using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DestroyPlastic : MonoBehaviour {

    public GameObject Winpanel;

    /*public void Update() {
        if (GameObject.FindGameObjectsWithTag("Trash") = null) {
            Debug.Log("null!");
            Winpanel.gameObject.SetActive(true);
        }
    }*/

    public void OnMouseDown() {
        Destroy(gameObject);
    }

    /*public void OnDestroy() {
        Debug.Log("Destroy: " + name);
    }*/
}
