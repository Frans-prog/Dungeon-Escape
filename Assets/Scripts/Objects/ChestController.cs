using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenChest()
    {
        if(!isOpen)
        {
            isOpen = true;
            anim.SetBool("isOpen", true);
            GetComponent<LootBag>().InstantiateLoot(transform.position);

        }
    }
    
}
