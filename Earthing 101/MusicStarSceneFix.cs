using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarSceneFix : MonoBehaviour
{
    public GameObject musicManager;

    void Start()
    {
        if (GameObject.Find("Music Manager") == null)
        {
            //it exists
            Instantiate(musicManager);
        }

        if (GameObject.Find("Music Manager") != null) {
            //it exists
            Destroy(musicManager);

        }
    }
}