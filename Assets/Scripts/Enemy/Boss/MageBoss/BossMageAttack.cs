using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMageAttack : MonoBehaviour
{
    public GameObject projectile, empoweredProjectile;
    public float fireRate = 2f;
    private Transform player;
    private Animator animator;
    public Transform firePosition1, firePosition2, firePosition3;

    private float timeBetweeenShots;
    public float startTimeBetweenShots;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    public void Fire()
    {
      Instantiate(projectile, firePosition1.position, Quaternion.identity);
      timeBetweeenShots = startTimeBetweenShots;
    }

    private void RageFire()
{
    
    Instantiate(empoweredProjectile, firePosition1.position, Quaternion.identity);
    Instantiate(empoweredProjectile, firePosition2.position, Quaternion.identity);
    Instantiate(empoweredProjectile, firePosition3.position, Quaternion.identity);
    timeBetweeenShots = startTimeBetweenShots;
}

   
   
}
