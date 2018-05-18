using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour {

    //How much health should the wall have at the start of the game
    public int startingHealth = 10;
    //X and Y scale of the wall sprite
    public bool scaleX = true;
    public bool scaleY = true;

    //Current health of the wall
    private int health;

	// Use this for initialization
	void Start () {
        //Set up health and set the wall's color to green
        health = startingHealth;
        this.GetComponent<SpriteRenderer>().color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
        //Destroy the wall when its health is down to 0
        if (health <= 0)
        {
            //SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
	}

    //Used for dealing damage to the wall
    public void DealDamage(int amount)
    {
        //Update health
        health = health - amount;
        //Scale wall (decrease the size) when its health gets lowered
        float scale = ((float)health / (float)startingHealth);
        Vector3 newScale = new Vector3((float)1.164844, (float)0.5356659, 1);
        if (scaleX)
            newScale.x = scale;
        if (scaleY)
            newScale.y = scale;
        this.transform.localScale = newScale;

        //Change the wall's color depending on how much health is has left compared to its max health
        if ((double)health / (double)startingHealth <= 0.66d)
            this.GetComponent<SpriteRenderer>().color = Color.yellow;
        else if ((double)health / (double)startingHealth <= 0.33d)
            this.GetComponent<SpriteRenderer>().color = Color.red;
        else
            this.GetComponent<SpriteRenderer>().color = Color.green;
    }

    /*void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Enemy")
        {
            obj.gameObject.GetComponent<Enemy>().ArriveAtWall();

            if (obj.gameObject.GetComponent<Enemy>().explodeOnDeath)
            {
                obj.gameObject.GetComponent<Enemy>().Kill();
            }
        }
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Explosion")
        {
            DealDamage(1);
        }
        else if (obj.gameObject.tag == "Enemy")
        {
            obj.gameObject.GetComponent<Enemy>().moving = false;
            DealDamage(obj.gameObject.GetComponent<Enemy>().damage);
        }
    }*/
}
