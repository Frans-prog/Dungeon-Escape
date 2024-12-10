using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyScript : MonoBehaviour
{
    public Transform firePosition;
    public GameObject projectile;
    private Transform player;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    public void Fire()
    {
      Instantiate(projectile, firePosition.position, Quaternion.identity);
    }
}
