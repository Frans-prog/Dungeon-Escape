using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBossAttack : MonoBehaviour
{
    public int attackDamage = 20;
	public int enragedAttackDamage = 40;

	public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;

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
			Debug.Log("Attacked by the DeathBoss");
		}
	}

	public void RagedAttack()
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
