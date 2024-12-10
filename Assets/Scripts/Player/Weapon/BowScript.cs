using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class BowScript : MonoBehaviour
{
    public Transform firePosition;
    public GameObject arrow;
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
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }

    }

    public void Fire()
    {
        Instantiate(arrow, firePosition.position, firePosition.rotation);
         attackSoundEffect.Play(); 
    }
}
