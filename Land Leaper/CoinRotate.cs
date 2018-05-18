using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour {

    public float speed = 3f; 
   
	void Start () {
		
	}
	
	void Update () {
        transform.Rotate(0, 0, speed);
		
	}
}
