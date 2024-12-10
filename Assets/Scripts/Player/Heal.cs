using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class Heal : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public UnityEvent buttonClick;
    public int healValue;
    //public GameObject gameObject;

    void Awake()
    {
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }
    }

    public void HealPlayer()
    {
        Debug.Log("Heal");
        playerHealth.Heal(healValue);
        buttonClick.Invoke();
        
    }

}
