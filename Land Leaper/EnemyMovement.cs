using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    Animator anim;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetTrigger("Walk");
    }

    private void Update()
    {
        nav.SetDestination(player.position);
    }


}