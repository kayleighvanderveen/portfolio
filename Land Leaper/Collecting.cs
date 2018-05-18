using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour {

    public int value;
    public float rotateSpeed;
    
	public void Update () {
        transform.Rotate(0, 0, rotateSpeed);
    }

    private void OnTriggerEnter() {
        GameManager.instance.Collect (value, gameObject);

        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
