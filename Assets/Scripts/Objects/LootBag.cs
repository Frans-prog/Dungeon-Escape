using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
    public GameObject droppedItem;
    public List<GameObject> lootList = new List<GameObject>();

    GameObject GetDroppedItem()
    {
        List<GameObject> possibleItems = new List<GameObject>();

        foreach(GameObject item in lootList)
        {
            possibleItems.Add(item);
        }
        if(possibleItems.Count > 0)
        {
            GameObject droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        Debug.Log("No loot");
        return null;
    }

    public void InstantiateLoot(Vector3 spawnPosition)
    {
        GameObject droppedItem = GetDroppedItem();
        if(droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(droppedItem, spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<SpriteRenderer>();
            
            float dropForce = 0.2f;
            Vector2 dropDirection = new Vector2(Random.Range(-1f,1f), Random.Range(-1f,1f));

            
        }
    }

}
