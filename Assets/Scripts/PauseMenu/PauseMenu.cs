using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuScreen;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuScreen.SetActive(false);
    }
    public void MenuScene()
    {
        // var dontDestroyObjects = FindObjectsOfType<MonoBehaviour>();
        // foreach (var obj in dontDestroyObjects)
        // {
        //     // Ignore the object that this script is attached to
        //     if (obj.gameObject == gameObject)
        //     {
        //         continue;
        //     }
        //     // Destroy the object
        //     Destroy(obj.gameObject);
        // }
        SceneManager.LoadScene("NewMainMenu");
        Time.timeScale = 1f;
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            // Set player's health to max when going back to the main menu scene
            playerHealth.currentHealth = playerHealth.maxHealth;
            playerHealth.healthBar.SetHealth(playerHealth.currentHealth);
        }
    }
}

