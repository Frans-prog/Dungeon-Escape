using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkipButton : MonoBehaviour
{

    public void GoToMainMenu(){
        SceneManager.LoadScene("NewMainMenu");
        Time.timeScale = 1f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
     
}
