using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdle : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    public float followRange = 15f;
    public float speed = 2.5f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float distanceToPlayer = Vector2.Distance(rb.position, player.position);

        if (distanceToPlayer <= followRange)
        {
            animator.SetBool("Running", true);
        }
        else if (distanceToPlayer >= followRange) 
        {
            animator.SetBool("Running", false);
        }
    }
}
