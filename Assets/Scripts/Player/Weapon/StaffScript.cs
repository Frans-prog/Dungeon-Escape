using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;

public class StaffScript : MonoBehaviour
{
    public Transform firePosition;
    public GameObject Orb;
    public UnityEvent buttonClick;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    [SerializeField] private AudioSource attackSoundEffect;
    void Update()
    {
       if (CrossPlatformInputManager.GetButtonDown("Attack") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();
        }
    }
     void Awake()
    {
        //animator.SetTrigger("Attack");
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }

    }

    public void Fire()
    {
        Instantiate(Orb, firePosition.position, firePosition.rotation);
        attackSoundEffect.Play(); 
    }
}
