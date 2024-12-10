using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimated : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDoor()
    {
        anim.SetBool("Open", true);
    }
    public void ClosedDoor()
    {
        anim.SetBool("Open", false);
    }
}
