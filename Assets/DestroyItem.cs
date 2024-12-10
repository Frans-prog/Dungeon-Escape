using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class DestroyItem : MonoBehaviour
{

public Tilemap destructableTilemap;
    // Start is called before the first frame update
private void Start()
    {
       destructableTilemap = GetComponent<Tilemap>(); 
    }

private void OnCollisionEnter2D (Collision2D collision)
{
    if (collision.gameObject.CompareTag("Weapon"))
    {
       Destroy(destructableTilemap.gameObject);
    }
}


    // Update is called once per frame
    void Update()
    {
        
    }
}
