using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPole : MonoBehaviour {

    public void OnTriggerEnter() {
        WinManager.instance.Win();
    }
}
