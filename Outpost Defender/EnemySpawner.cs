using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    //How many frames(1/60st second) the spawner should wait before spawning a new enemy
    public int frequency = 180;

    //Timer that checks how many frames have passed. Used in combination with 'frequency'
    private int timer = 0;
    private int nextSpawn = 0;

    private int enemyTimer = 1500;

    void Update() {
        timer += 1;

        // timer >= enemy timer, stop the enemy spawner. 
        if (timer >= enemyTimer) {
            nextSpawn = 1;
        }

        //Spawns a new enemy
        if (nextSpawn == 0) {
            GameObject enemy;
            //Generates a random number. That number decides which enemy prefab should be spawned on the field
            int random = Random.Range(0, 100);
            if (random <= 15)
                enemy = (GameObject)Instantiate(Resources.Load("Zapper"));
            else if (random <= 30)
                enemy = (GameObject)Instantiate(Resources.Load("Bomber"));
            else if (random <= 40)
                enemy = (GameObject)Instantiate(Resources.Load("Bellybutton"));
            else
                enemy = (GameObject)Instantiate(Resources.Load("Enemy"));

            //Factor by which the spawn location if the enemy that should be spawned should be randomized (relative to the location of the enemy spawner)
            float randomScale = 0.8f;

            //Set the new enemies location
            enemy.transform.position = new Vector3(this.transform.position.x + Random.Range(randomScale * -1, randomScale),
                                                   this.transform.position.y + Random.Range(randomScale * -1, randomScale),
                                                   this.transform.position.z + Random.Range(randomScale * -1, randomScale));
            nextSpawn = frequency;
        }

        nextSpawn -= 1;
    }
}