using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }


    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            for(int i = 0; i < inventory.slots.Length; i++){
                //ichecheck kung may laman na yung item slot pag dumikit yung player sa object
                if(inventory.isFull[i] == false){
                //pag walang laman yung item slot, lalagyan niya ng laman
                inventory.isFull[i] = true;
                //tratransform niya yung laman ng itemslot kung ano yung pinick up na item.
                Instantiate(itemButton, inventory.slots[i].transform, false);
                //Para mawala yung object upon contact or pickup
                Destroy(gameObject);
                break;
                }
            }
        }
    }

}
