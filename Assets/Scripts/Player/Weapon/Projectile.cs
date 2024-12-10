using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectSpeed;
    public int damage;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = transform.right * projectSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
        EnemyHealth enemyHealth = collision.gameObject.GetComponentInChildren<EnemyHealth>();
        enemyHealth.TakeDamage(damage);  
        }
        if(collision.gameObject.tag == "Boss")
        {
            //playerHealth.TakeDamage(damage);
            FindObjectOfType<BossHealth>().TakeDamage(damage);
            Debug.Log(damage);
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

        Destroy(gameObject);
    }
}
