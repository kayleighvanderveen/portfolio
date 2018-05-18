using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private Transform player;
    private NavMeshAgent nav;
    private Animator anim;

    public void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetTrigger("Walk");
    }

    private void Update() {
        nav.SetDestination(player.position);
    } 
}
