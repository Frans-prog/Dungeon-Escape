using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Enemy"))
        {
            EnemyHealth health = collider.GetComponent<EnemyHealth>();
            health.TakeDamage(damage);
        }
    }
}
