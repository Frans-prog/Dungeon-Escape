using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMove_ref2 : MonoBehaviour
{
     
     public string nextSceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerPrefs.HasKey("Level 2 [Final]Completed"));
        {
           
            SceneManager.LoadScene("Level 3 [Final]");
            Debug.Log("WORKING");
                    
        }
    }
}
