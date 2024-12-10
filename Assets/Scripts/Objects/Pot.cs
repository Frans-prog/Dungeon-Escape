using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private AudioSource VaseBreakSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Break()
    {
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        anim.SetBool("Break", true);
        Destroy(gameObject, 0.3f);
        VaseBreakSoundEffect.Play(); 
    }
}
