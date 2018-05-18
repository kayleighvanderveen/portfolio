using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour {

    public CircleCollider2D hitBox; 

	// Use this for initialization
	void Start () {
        hitBox = GetComponent<CircleCollider2D>();
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Update 
        if (Input.GetMouseButtonDown(0)) {
            hitBox.enabled = true;
        }

        if (Input.GetMouseButtonUp(0)) {
            hitBox.enabled = false;
        }

        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
    }
}
