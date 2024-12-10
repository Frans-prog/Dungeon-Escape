using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public GameObject playerPosition;
    public int damage;
    private Transform target;

    // The RoomTrigger component in the scene
    private RoomTrigger roomTrigger;

    private void Start()
    {
        roomTrigger = FindObjectOfType<RoomTrigger>();
    }

    private void Update()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) > 1f)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, target.position, step);
            }
        }

        if (gameObject.transform.position.x > playerPosition.transform.position.x)
        {
            gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (gameObject.transform.position.x < playerPosition.transform.position.x)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().TakeDamage(damage);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
        }

        if (gameObject.transform.position.x >= 0.01f)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (gameObject.transform.position.x <= 0.01f)
        {
            gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
        }
    }

}
