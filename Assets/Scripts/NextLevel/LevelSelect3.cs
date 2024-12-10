using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelect3 : MonoBehaviour
{
    
    public GameObject levelCanvas;
    
   
   public void openLevel()
{
    levelCanvas.SetActive(true);
}

public void closeLevel()
{
    levelCanvas.SetActive(false);
}

public void openLevel1()
{

                FindObjectOfType<LoadingManager>().LoadingScreen("Level 1 [Final]");
              


}

public void openLevel2()
{
   if (PlayerPrefs.GetInt("Level 1 [Final]Completed") == 1) {
       
                FindObjectOfType<LoadingManager>().LoadingScreen("Level 2 [Final]");




    }

}

public void openLevel3()
{
    if (PlayerPrefs.GetInt("Level 2 [Final]Completed") == 1) {
        
             FindObjectOfType<LoadingManager>().LoadingScreen("Level 3 [Final]");
   
        
    }
}
public void openLevel4()
{
    if (PlayerPrefs.GetInt("Level 3 [Final]Completed") == 1) {
       
              FindObjectOfType<LoadingManager>().LoadingScreen("Level 4 [Final]");

        
    }
}
public void openLevel5()
{
    if (PlayerPrefs.GetInt("Level 4 [Final]Completed") == 1) {
        
              FindObjectOfType<LoadingManager>().LoadingScreen("Level 5 [Final]");
            
        
    }
}

private void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == "Player") {
        // Call this method when a level is completed to mark it as completed
        completeLevel("Level 3 [Final]");
    }
}

public void completeLevel(string levelName) {
    PlayerPrefs.SetInt(levelName + "Completed", 1);
    PlayerPrefs.Save();
}

     
}
