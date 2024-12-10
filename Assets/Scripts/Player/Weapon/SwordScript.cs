using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;

public class SwordScript : MonoBehaviour
{
    private Animator animator;
    public UnityEvent buttonClick;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    [SerializeField] private AudioSource attackSoundEffect;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        animator = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Attack") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            SwordAttack();
        }
        
    }

   
    public void SwordAttack()
    {  
        animator.SetTrigger("Slash");
        print("Attacked");
        buttonClick.Invoke();
        attackSoundEffect.Play();     
    }

}
