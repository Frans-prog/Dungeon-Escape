using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;

public class AttackButton : MonoBehaviour
{
    public UnityEvent buttonClick;

    public float attackRate;
    float nextAttackTime = 0f;
    bool pressedAttack = false;
    

    void Awake()
    {
        //animator.SetTrigger("Attack");
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }

    }
    void FixedUpdate()
    {
       //Timer to avoid spamming
        if(Time.time >= nextAttackTime){
            if(pressedAttack == true){
              Attack();
            }
            pressedAttack = false;
            nextAttackTime = Time.time+ 1f/attackRate;
        }
    }
    public void Attack()
    {
         if(CrossPlatformInputManager.GetButtonDown("Attack"))
            {
                pressedAttack = true;
                print("Attacked");
                buttonClick.Invoke();
              
            }
        else{
            pressedAttack = false;
        }
    }
}
