using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    //Number of frames before the explosion should be removed (how long it will survive)
    public int framesBeforeDeath = 120;
    private int framesToWait = 0;

	// Use this for initialization
	void Start () {
        framesToWait = framesBeforeDeath;
        //Set explosion scale
        transform.localScale *= 5;
	}
	
	// Update is called once per frame
	void Update () {
        //Update timer
        framesToWait -= 1;
        //Check if the explosion should be destroyed
        if (framesToWait <= 0)
            Destroy(gameObject);
	}

    void OnTriggerEnter2D(Collider2D obj)
    {
        //Kill enemy that enters the explosion
        if (obj.tag == "Enemy")
            obj.gameObject.GetComponent<Enemy>().Kill();
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        //Damage wall if it is inside the explosion
        if (framesToWait >= framesBeforeDeath - 1)
        {
            if (obj.tag == "Wall")
                obj.gameObject.GetComponent<Wall>().DealDamage(1);
        }
    }
}
