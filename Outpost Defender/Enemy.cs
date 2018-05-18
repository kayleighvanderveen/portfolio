using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //Movement speed
    public float speed = 3.0f;
    //Damage dealt to a wall when enemy attacks it
    public int damage = 1;
    //How many frames(1/60st second) the enemy waits between attacking when it colliding with a wall
    public int attackInterval = 60;
    //For the Bloater enemy. If this is true, enemy will explode when it dies
    public bool explodeOnDeath = false;
    //Scale of the enemy
    public float scale = 1.0f;
    //If this is true, enemy sprite will have a breathing effect applied to it
    public bool breathing = false;
    //If this is true, the enemy moves during the frame and its position is updated
    public bool moving = true;

    //If enemy is breathing, these will decide how much the X and Y of the enemy is scaled
    protected float breathingMin, breathingMax, breathingSpeed;
    protected bool breathingIncrease = true;
    //Timer that drops by 1 each single frame. If it is 0, enemy attacks if it is currently touching a wall
    protected int attackTimer;

    protected Vector2 direction = new Vector2(0, 0);

    private Animator anim;

    // Use this for initialization
    void Start () {
        //Set up the attack timer
        attackTimer = attackInterval;
        //Calculate in which direction the enemy should move and build a direction vector with the result
        CalcDirection();
        //Calculate which direction (rotation) the enemy sprite should face (always downwards in the current version of the game)
        Vector2 dir = new Vector2(direction.x * -1, direction.y * -1);
        transform.up = dir;
        transform.localScale = new Vector3(scale, scale, transform.localScale.z);

        //Set up breathing effect if enemy should have a breathing effect applied to it
        if (breathing)
        {
            breathingMin = scale - scale * 0.1f;
            breathingMax = scale + scale * 0.1f;
            breathingSpeed = scale * 0.1f / 60.0f;
        }

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	public virtual void Update () {
        //If enemy should move, this updates its position by using the direction vector
        if (moving)
            this.transform.position = new Vector3(this.transform.position.x + direction.x, this.transform.position.y + direction.y, this.transform.position.z);

        //Takes care of the breathing effect each update
        if (breathing)
        {
            if (breathingIncrease)
            {
                scale += breathingSpeed;
                if (scale >= breathingMax)
                    breathingIncrease = false;
            }
            else
            {
                scale -= breathingSpeed;
                if (scale <= breathingMin)
                    breathingIncrease = true;
            }
            transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);
        }
	}

    // Kill and remove the enemy from the game
    public virtual void Kill ()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        anim.SetTrigger("grunt die");
        moving = false;
        //If enemy should explode, loads a explosion prefab and spawns it on top of this enemy
        if (explodeOnDeath)
        {
            GameObject exp = (GameObject)Instantiate(Resources.Load("Explosion"));
            exp.transform.position = transform.position;
        }
        //Update the game's kill count
        GameObject.FindGameObjectsWithTag("Manager")[0].GetComponent<Manager>().kill += 1;
        //Destroy the enemy and remove it from the field
        Destroy(gameObject, 1);

    }

    //Calculate moving direction
    public void CalcDirection()
    {
        direction = new Vector2(0, -1);
        direction.Normalize();
        direction /= 200;
        direction *= speed;
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        //Makes the enemy start moving again when a wall is destroyed
        if (obj.gameObject.tag == "Wall")
        {
            moving = true;
            anim.SetBool("grunt range", false);
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        //Stop enemy from moving when it hits a wall and interact with the wall
        if (obj.gameObject.tag == "Wall")
        {
            moving = false;
            attackTimer = attackInterval;
            anim.SetBool("grunt range", true);
        }
        //Kill the enemy when hit by a marble
        else if (obj.gameObject.tag == "Marble")
        {
            Kill();
        }
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        //Kill enemy when it hits an explosion
        if (obj.gameObject.tag == "Explosion")
        {
            Destroy(gameObject);
        }
        //Handle actions that should be taken when enemy first enters/hits a wall
        else if (obj.gameObject.tag == "Wall")
        {
            if (explodeOnDeath)
                Kill();
            if (attackTimer == 0)
            {
                obj.gameObject.GetComponent<Wall>().DealDamage(damage);
                attackTimer = attackInterval;
            }
            attackTimer -= 1;
        }
    }

    /*void OnMouseDown() {
        Destroy(gameObject);
    }*/
}
