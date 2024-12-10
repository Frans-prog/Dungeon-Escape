using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPickup : MonoBehaviour
{
    private GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    //Excutes when the player collides with the GameObject (Weapons)
    private void OnTriggerEnter2D(Collider2D potion)
    {

        if(potion.CompareTag("Player"))
        {
            Debug.Log("Added 3 Potion : "+gameObject);
            Player.GetComponent<UsePotion>().AddHealthPotion();
            Destroy(gameObject);
        }   
    }
}
