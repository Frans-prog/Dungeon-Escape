using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
   
  void OnEnable() 
     {
        SceneManager.LoadScene("NewMainMenu");
        Time.timeScale = 1f;
     }
}


