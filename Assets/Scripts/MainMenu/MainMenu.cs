using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public void PlayGame(){
 
    //             SceneManager.LoadScene("Level 1");
              
    //     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }
    [SerializeField] RectTransform fader;


    //Transition to the actual game
    public void PlayGame(){
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3 (1,1,1),0.5f).setOnComplete(() => {
                SceneManager.LoadScene("Level 1 [Final]");
              
        });
        
    }

    public void QuitGame(){

        Debug.Log("quit");
        Application.Quit();
    }
 
}
