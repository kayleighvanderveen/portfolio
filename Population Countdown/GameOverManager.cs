using UnityEngine;

public class GameOverManager : MonoBehaviour {

    public PlayerHealth playerHealth; 
    public float restartDelay = 5f;    
    private Animator anim;                   
    private float restartTimer;             


    public void Awake() {
        anim = GetComponent<Animator>();
    }


    public void Update() {
        if (playerHealth.currentHealth <= 0) {
            anim.SetTrigger("GameOver");
            
            restartTimer += Time.deltaTime;
            
            if (restartTimer >= restartDelay) {
                Application.LoadLevel("MainMenu");
            }
        }
    }
}