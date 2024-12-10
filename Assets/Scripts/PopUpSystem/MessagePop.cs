using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePop : MonoBehaviour
{
    public GameObject Message;
   

//when the player comes close into contact the collider, it triggers this event
    private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        Message.SetActive(true);
    }
}
//when the player exits the collider, it triggers this event
       private void OnTriggerExit2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        Message.SetActive(false);
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
