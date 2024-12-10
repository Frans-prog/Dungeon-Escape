using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BarthaSzabolcs.Tutorial_SpriteFlash;

public class CharacterHealthDamage : MonoBehaviour
{
    private PlayerHealth playerhealth;
    private SimpleFlash simpleFlash;

    // Start is called before the first frame update
    void Start()
    {
        playerhealth = transform.parent.GetComponentInParent<PlayerHealth>();
        simpleFlash = GetComponent<SimpleFlash>();

    }

    public void TakeDamage(int damage)
    {
        playerhealth.TakeDamage(damage);
        simpleFlash.Flash();

    }
}
