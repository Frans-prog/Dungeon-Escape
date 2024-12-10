using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class UsePotion : MonoBehaviour
{
    public GameObject button;
    public TMP_Text  PotionCounterText;
    private GameObject Player;
    public int healthPotion = 0; 
    bool pressedHeal = false;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {  
        if(pressedHeal == true){
            //Check the number of healthPotion left
            if(healthPotion > 0){
                healthPotion--; 
                PotionCounterText.text = ((int)healthPotion).ToString();
                Player.GetComponent<Heal>().HealPlayer();
            }   
            pressedHeal = false;
        }
    }
    

    //Onclick ThrowButton
    public void HealthPotionHeal(){
        pressedHeal = true;
    }

    public void AddHealthPotion(){
        button.SetActive(true);
        healthPotion = healthPotion + 1;
        PotionCounterText.text = ((int)healthPotion).ToString();
    }
    
}
