using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryMenu : MonoBehaviour
{
    public GameObject InventoryMenuScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InventoryMenupause()
     {
        Time.timeScale = 0f;
        InventoryMenuScreen.SetActive(true);
     }
      public void ResumeGame()
    {
        Time.timeScale = 1f;
        InventoryMenuScreen.SetActive(false);
    }
}
