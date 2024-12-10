using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    private GameObject playerPosition;
    private Transform target;
    

    void Start()
    {
      playerPosition = GameObject.FindGameObjectWithTag("Player");
    }

    public void LookAtPlayer()
    {
       if(gameObject.transform.position.x > playerPosition.transform.position.x)
      {
        gameObject.transform.localScale = new Vector3(-1f,1f,1f);
      }
      
      else if(gameObject.transform.position.x < playerPosition.transform.position.x)
      {
        gameObject.transform.localScale = new Vector3(1f,1f,1f);
      }
    }
}
