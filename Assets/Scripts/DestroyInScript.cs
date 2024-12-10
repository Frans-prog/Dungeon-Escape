using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInScript : MonoBehaviour
{
    
    public float secondsToDestroy = 1f;
    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }

}
