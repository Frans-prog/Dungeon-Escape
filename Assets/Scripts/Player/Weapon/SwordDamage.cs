using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public int damage ; 
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.CompareTag("Enemy"))
        {

            //playerHealth.TakeDamage(damage);
           EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        enemyHealth.TakeDamage(damage);  
        }
        // if(collision.gameObject.tag == "Enemy")
        // {

        //     //playerHealth.TakeDamage(damage);
        //    EnemyHealth enemyHealth = collision.gameObject.GetComponentInChildren<EnemyHealth>();
        // enemyHealth.TakeDamage(damage);  
        // }
        if(collision.gameObject.tag == "Boss")
        {
            //playerHealth.TakeDamage(damage);
            BossHealth bossHealth = collision.gameObject.GetComponent<BossHealth>();
        bossHealth.TakeDamage(damage);  
            // FindObjectOfType<BossHealth>().TakeDamage(damage);
            // Debug.Log(damage);
        }

        if(collision.gameObject.tag == "Chest")
        {
            // FindObjectOfType<ChestController>().OpenChest();
            collision.gameObject.GetComponent<ChestController>().OpenChest();
        }

        if(collision.gameObject.tag == "Breakable")
        {
            collision.gameObject.GetComponent<Pot>().Break();
        }
        
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.CompareTag("Breakable"))
    //     {
    //         other.GetComponent<Pot>().Break();
    //     }
    // }
}
