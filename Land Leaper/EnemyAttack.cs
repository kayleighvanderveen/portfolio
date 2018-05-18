using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour {

    public GameObject player;
    public PlayerHealth playerHealth;
    public float timer;
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;              
                      
    private bool playerInRange;                  
                              

    private string loadedLevel;

    public void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject == player) {
            playerInRange = true;
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.gameObject == player) {
            playerInRange = false;
        }
    }

    public void Update() {
        timer += Time.deltaTime;
        
        if (timer >= timeBetweenAttacks && playerInRange) {
            Attack();
        }

        if (playerHealth.currentHealth <= 0) {
            SceneManager.LoadScene(loadedLevel);
        }
    }

    public void Attack() {
        timer = 0f;
        
        if (playerHealth.currentHealth > 0) {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}