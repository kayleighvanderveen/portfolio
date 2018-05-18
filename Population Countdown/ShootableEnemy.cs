using UnityEngine;
using System.Collections;

public class ShootableEnemy : MonoBehaviour {

    public int currentHealth = 3;
    public int scoreValue = 10;               

    public void Damage(int damageAmount) {
        currentHealth -= damageAmount;
        if (currentHealth <= 0) {
            gameObject.SetActive(false);
            ScoreManager.score += scoreValue;
        }
    }
}
