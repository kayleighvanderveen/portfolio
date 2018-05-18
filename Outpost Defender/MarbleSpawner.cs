using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleSpawner : MonoBehaviour {

    //Is true if the mouse button was pressed the previous frame
    private bool prevMouse = false;
    //Sound effect that should be played when spawning a marble
    public AudioSource shotSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Spawn marble when mouse button is pressed
        if (!prevMouse && Input.GetMouseButtonDown(0))
        {
            ShootMarble();
        }
        prevMouse = Input.GetMouseButtonDown(0);
    }

    void ShootMarble()
    {
        //Spawn marble
        Instantiate(Resources.Load("Marble"));
        shotSound.Play();
    }
}
