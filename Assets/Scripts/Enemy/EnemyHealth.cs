using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth;
    public float knockbackForce = 10f;
    public float knockbackDuration = 0.3f;

    // The RoomTrigger component in the scene
    public RoomTrigger roomTrigger;

    
    // The TestRoomTrigger component in the scene
    // private TestRoomTrigger roomTrigger;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        roomTrigger = GetComponentInParent<RoomTrigger>();
        // roomTrigger = GetComponentInChildren<TestRoomTrigger>();
        
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            GetComponent<Animator>().SetTrigger("Dead");
            Destroy(gameObject, 1f);

            if (roomTrigger != null)
            {
                // Call the EnemyKilled() method in the RoomTrigger script
                  if (roomTrigger != null)
                  {
                      roomTrigger.EnemyKilled(gameObject);
                      Debug.Log("Its working here");
                  }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Weapon")
    {
        Vector2 difference = transform.position - other.transform.position;
        Vector2 knockbackDirection = difference.normalized;
        GetComponent<Rigidbody2D>().AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
        StartCoroutine(EndKnockback());
    }
}

private IEnumerator EndKnockback()
{
    yield return new WaitForSeconds(knockbackDuration);
    GetComponent<Rigidbody2D>().velocity = Vector2.zero;
}

}
