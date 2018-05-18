using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager instance = null;
    //ScoreText in UI
    public Text scoreText;
    //KillText in UI
    public Text killText;
    //UI "score object"
    public GameObject scoreTextObject;
    //UI "kill object"
    public GameObject killTextObject;
    //Keeps track of the game's score (score is equal to the number of seconds the game has been going for)
    public int score = 0;
    //Keeps track of how long the game has been going
    private int timer = 0;
    //Kill count
    public int kill = 0;

    public AudioSource track1, track2, track3;
    private bool fadeInT1 = true;
    private bool fadeInT2 = false;
    private bool fadeInT3 = false;

    private void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

        scoreText = scoreTextObject.GetComponent<Text>();
        scoreText.text = "Score: " + score.ToString();

        killText = killTextObject.GetComponent<Text>();
        killText.text = "Score: " + kill.ToString();
    }

    // Use this for initialization
    void Start () {
        /*
         highScore.text = playerPrefs.GetInt("HighScore", 0).ToString();*/
        track1.volume = 0;
        track2.volume = 0;
        track3.volume = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //Update timer and maybe the score
        timer += 1;
        if (timer >= 60)
        {
            timer = 0;
            score += 1;
        }

        scoreText.text = "Score: " + score.ToString();
        killText.text = "Kill: " + kill.ToString();

        //Check for music changing keys
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            fadeInT1 = true;
            fadeInT2 = false;
            fadeInT3 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            fadeInT1 = false;
            fadeInT2 = true;
            fadeInT3 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            fadeInT1 = false;
            fadeInT2 = false;
            fadeInT3 = true;
        }

        if (fadeInT1 == true)
            track1.volume += 0.001f;
        else
            track1.volume -= 0.0014f;

        if (fadeInT2 == true)
            track2.volume += 0.001f;
        else
            track2.volume -= 0.001f;

        if (fadeInT3 == true)
            track3.volume += 0.001f;
        else
            track3.volume -= 0.001f;
    }

    /*void OnGUI()
    {
        //Print score and kill count information on the screen
        GUI.color = Color.black;
        GUI.Label(new Rect(300, 0, 200, 200), "Score: " + score.ToString());
        GUI.Label(new Rect(300, 20, 200, 200), "Kill: " + kill.ToString());
    }*/


}
