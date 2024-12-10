using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    // public EnemyHealth enemyHealth;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
        FindObjectOfType<CharacterHealthDamage>().TakeDamage(damage);
        }
    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //     FindObjectOfType<PlayerHealth>().TakeDamage(damage);
    //     }
        // if(collision.gameObject.tag == "Enemy")
        // {
        // enemyHealth.TakeDamage(damage);
        // }
    }
}
