using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bellybutton : MonoBehaviour {

    public float moveSpeed;
    public int damage;
    public int hp = 2;
    public int windupTime;
    public int backswingTime;
    public int attackTimer = 0;
    public int staggerDistance;
    //public bool inRange = false;
    public bool attacking = false;
    public bool stagger = false;
    public float staggerframes = 30;
    float staggerTime;
    float staggerT = 0;
    Vector2 staggerFro;
    Vector2 staggerTo;

    public RaycastHit2D hit;
    public float range;
    public LayerMask mask;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        staggerTime = 1 / staggerframes;
    }

    void FixedUpdate()
    {
        if (!stagger) {
            if (!attacking) {
                if (Physics2D.Raycast(transform.position, Vector2.down, range, mask)) {
                    anim.SetBool("In range", true);
                    attacking = true;
                    Attack();
                } else {
                    anim.SetBool("In range", false);
                    Move();
                }
            } else {
                Attack();
            }
        } else {
            transform.position = Vector2.Lerp(staggerFro, staggerTo, staggerT);
            staggerT += staggerTime;
            if (staggerT >= 1) {
                anim.SetBool("Hit", false);
                stagger = false;
            }
        }
    }

        void Move()
    {
        transform.Translate(0, moveSpeed * -1, 0);
    }

    void Attack ()
    {
        if(attackTimer >= windupTime + backswingTime)
        {
            attacking = false;
            attackTimer = 0;
        }
        else 
        {
            if (attackTimer == windupTime)
            {
                anim.SetTrigger("Laser");
                hit = Physics2D.Raycast(transform.position, Vector2.down, range, mask);
                if (hit.collider != null)
                {
                    hit.transform.gameObject.GetComponent<Wall>().DealDamage(damage);
                }
            }
            attackTimer++;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (attacking)
        {
            if (other.gameObject.tag == "Marble")
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                attacking = false;
                hp--;
                if(hp > 0)
                {
                    anim.SetBool("Hit", true);
                    stagger = true;
                    staggerT = 0;
                    staggerFro = transform.position;
                    staggerTo = new Vector2(transform.position.x, transform.position.y+staggerDistance);
                }
                else
                {
                    anim.SetBool("Die", true);
                    Destroy(gameObject, 2);
                    moveSpeed = 0;
                }
            }
        }
    }

    /*void OnMouseDown() {
        Destroy(gameObject);
    }*/
}
