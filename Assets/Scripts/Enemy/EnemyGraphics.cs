using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGraphics : MonoBehaviour
{
       public AIPath aiPath; 
    //Dapat yung default facing ng enemy ay nasa left
    // Update is called once per frame
    void Update()
    {
      if(aiPath.desiredVelocity.x >= 0.01f)
      {
        transform.localScale = new Vector3(-1f,1f,1f);
      }  
      
      else if(aiPath.desiredVelocity.x <= 0.01f)
      {
        transform.localScale = new Vector3(1f,1f,1f);
      }
    }
}
