using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpikeAnimationSpeed2 : MonoBehaviour
{
    private Animator animator;
    public float speedMultiplier = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        var state = animator.GetCurrentAnimatorStateInfo(0);
        animator.Play(state.fullPathHash, 0, Random.Range(0f, 1f));
    }

void Update()
    {
        animator.speed = speedMultiplier;
    }
    
}
