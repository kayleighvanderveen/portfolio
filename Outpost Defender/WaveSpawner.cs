using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    bool isSpawning = false;
    public int frequency = 80;
    public GameObject[] enemies;  
    public GameObject NextWavePanel;
    public Vector3 spawnValues;
    public int spawnBegin = 30;

    public int numberOfEnemies = 2;
    public int numberOfGrunt = 1;
    private int gruntLeft, nonGruntLeft;

    private int timer, timer2 = 0;

    void Awake() {
        NextWavePanel.SetActive(false);
        gruntLeft = numberOfGrunt;
        nonGruntLeft = numberOfEnemies - numberOfGrunt;
    }

    void Update() {
        timer += 1;
        if (NextWavePanel.activeSelf == true)
            timer2 += 1;

        //Stop spawning, if all enemies are gone from the scene then set panel to active
        if (GameObject.FindWithTag("Enemy") == null && gruntLeft <= 0 && nonGruntLeft <= 0) {
            isSpawning = true;
            NextWavePanel.SetActive(true);
            gruntLeft = numberOfGrunt;
            nonGruntLeft = numberOfEnemies - numberOfGrunt;
            //frequency /= 2;
        }
        //If panel is shown long enough, start spawners again and set UI panel to false
        else if (timer2 >= spawnBegin && NextWavePanel.activeSelf == true) {
            isSpawning = false;
            NextWavePanel.SetActive(false);
            timer = 0;
            timer2 = 0;
        }
        else if (NextWavePanel.activeSelf == false)
        {
            isSpawning = false;
            NextWavePanel.SetActive(false);
        }



        /*if (timer >= spawnBegin) {
            NextWavePanel.SetActive(false);
            isSpawning = false;
        }
        
        else {
            NextWavePanel.SetActive(false);
            isSpawning = false;
        }*/

        //Spawning one at the time
        if (!isSpawning && timer % frequency == 0 && (gruntLeft > 0 || nonGruntLeft > 0)) {
            isSpawning = true;
            int enemyIndex;
            if (nonGruntLeft > 0 && (gruntLeft == 0 || Random.Range(0, 100) <= 30))
            {
                enemyIndex = Random.Range(1, enemies.Length);
                nonGruntLeft -= 1;
            }
            else
            {
                enemyIndex = 0;
                gruntLeft -= 1;
            }
            SpawnObject(enemyIndex);
        }
        if (gruntLeft == 0 && nonGruntLeft == 0)
            isSpawning = true;
        Debug.Log(gruntLeft.ToString() + " " + nonGruntLeft.ToString());
    }

    void SpawnObject(int index) {

        //yield return new WaitForSeconds(seconds);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Instantiate(enemies[index], spawnPosition, transform.rotation);

        //Enemies spawned, start another spawn     
        //isSpawning = false;
    }
}


/*
 * //Specify Enemy
public GameObject[] enemies;
//Where to spawn
public Vector3 spawnValues;
//Amount of enemies
public int enemyCount;
//Time between enemies
public float spawnWait;
//Time wait for start
public float startWait;
//Time between waves
public float waveWait;
//UI panel
public GameObject NextWavePanel;

//Regular timer
private int timer = 0;

//UI panel off
void Awake() {
    NextWavePanel.SetActive(false);
}

//Spawn waves 
void Start() {
    StartCoroutine(SpawnWaves());
}

//Timer and panel
void Update() {
    timer += 1;

    //if spawner is off, turn panel on
    NextWavePanel.SetActive(true);

    //else if spawner is on, turn panel off
    NextWavePanel.SetActive(false);
}

// 
IEnumerator SpawnWaves(int index) {
yield return new WaitForSeconds(startWait);
while (true) {
    for (int i = 0; 
             i < enemyCount; 
             i++) {
        //Spawn enemies in random range
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        //Fixed rotation, aligned with world axes
        Quaternion spawnRotation = Quaternion.identity;
        //Instantiate enemy
        Instantiate(enemies[index], spawnPosition, spawnRotation);
        //Spawn new enemy after "" time
        yield return new WaitForSeconds(spawnWait);
            }
    //Do the same thing
    yield return new WaitForSeconds(waveWait);
    }
}
}
*/
