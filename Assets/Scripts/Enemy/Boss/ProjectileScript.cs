using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;
    public int damage;
    public int collideDamage;
    public int explosionDamage;
    public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
             DestroyProjectile();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<CharacterHealthDamage>().TakeDamage(damage);   
            
        }

        else if(other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    void DestroyProjectile()
    {
        anim.SetTrigger("Exploded");
        Destroy(gameObject, 0.5f);
    }

    public void Explosion()
	{
		Vector3 pos = transform.position;
		Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 offset = playerPos - transform.position;
		pos += offset.normalized * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		if (colInfo != null && colInfo.gameObject.CompareTag("Player"))
		{
			colInfo.GetComponent<CharacterHealthDamage>().TakeDamage(explosionDamage);
			Debug.Log("Attacked by the DeathBoss");
		}
	}
    public void Collide()
	{
		Vector3 pos = transform.position;
		Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 offset = playerPos - transform.position;
		pos += offset.normalized * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		if (colInfo != null && colInfo.gameObject.CompareTag("Player"))
		{
			colInfo.GetComponent<CharacterHealthDamage>().TakeDamage(collideDamage);
			Debug.Log("Attacked by the DeathBoss");
		}
	}

    void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
	}
}
