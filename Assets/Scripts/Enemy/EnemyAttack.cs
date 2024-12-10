using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int attackDamage = 20;
	public int collideDamage = 5;
	public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;
	public float followRange = 10f;
	

	public void Attack()
	{
		Vector3 pos = transform.position;
		Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 offset = playerPos - transform.position;
		pos += offset.normalized * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		if (colInfo != null && colInfo.gameObject.CompareTag("Player"))
		{
			colInfo.GetComponent<CharacterHealthDamage>().TakeDamage(attackDamage);
			Debug.Log("Attacked");
		}
	}
// 	public void Attack()
// {
//     Vector3 pos = transform.position;
//     GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
//     Debug.Log("Player object: " + playerObject);
//     Vector3 playerPos = playerObject.transform.position;
//     Vector3 offset = playerPos - transform.position;
//     pos += offset.normalized * attackOffset.x;
//     pos += transform.up * attackOffset.y;

//     Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
//     if (colInfo != null && colInfo.gameObject.CompareTag("Player"))
//     {
//         colInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
//         Debug.Log("Attacked");
//     }
// }

    void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
		Gizmos.DrawWireSphere(pos, followRange);
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
			Debug.Log("Attacked");
		}
	}
}
