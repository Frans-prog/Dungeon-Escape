using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform playerTransform;
    public float followRadius = 10f;
    public float movementSpeed = 5f;
    public int damage;

    // The RoomTrigger component in the scene
    private RoomTrigger roomTrigger;

     private void Start()
    {
        // Find the RoomTrigger component in the scene and assign it to the roomTrigger variable
        roomTrigger = FindObjectOfType<RoomTrigger>();
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("Could not find object with tag 'Player'!");
        }
    }

    private void Update()
    {
        if (playerTransform == null) return;
        
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        if (distanceToPlayer <= followRadius)
        {
            // Move towards the player
            Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
            transform.position += directionToPlayer * movementSpeed * Time.deltaTime;
             // Face the player position
             if (transform.position.x > playerTransform.position.x)
             {
            transform.localScale = new Vector3(-1f, 1f, 1f);
             }
            else if (transform.position.x < playerTransform.position.x)
             {
             transform.localScale = new Vector3(1f, 1f, 1f);
             }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().TakeDamage(damage);
        }
    }
    
}
