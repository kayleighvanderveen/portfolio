using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour {

    //See EnemySpawner.cs
    public int frequency2 = 180;
    private int nextSpawn2 = 0;

    private int enemyTimer2 = 2000;

    void Update() {
      
        //Spawn new enemy
        if (nextSpawn2 == 0) {
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
            nextSpawn2 = frequency2;
        }

        nextSpawn2 -= 1;
    }
}