using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public static LoadingManager Instance;
    public GameObject LoadingPanel;
    public float MinLoadTime;
    private bool isLoading;

    public Image fadeImage;
    public float fadeTime;

    private string targetScene;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this; 
            DontDestroyOnLoad(gameObject);
        }

        LoadingPanel.SetActive(false);
        fadeImage.gameObject.SetActive(false);
    }

    public void LoadingScreen(string sceneName)
    {
        targetScene = sceneName;
        isLoading = false;
        StartCoroutine(LoadSceneRoutine());
    }

    private IEnumerator LoadSceneRoutine()
    {
        isLoading = true;

        fadeImage.gameObject.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0);

        while(!Fade(1))
            yield return null;

        LoadingPanel.SetActive(true);

        while(!Fade(0))
            yield return null;
            
        AsyncOperation op = SceneManager.LoadSceneAsync(targetScene);
        float elapsedLoadTime = 0f;

        while(!op.isDone)
        {
            elapsedLoadTime += Time.deltaTime;
            yield return null;
        }
        if(op.isDone)
        {
            isLoading = true;
        }
        while(elapsedLoadTime < MinLoadTime)
        {
            elapsedLoadTime += Time.deltaTime;
            yield return null;
        }

        while(!Fade(1))
            yield return null;

         LoadingPanel.SetActive(false);

        while(!Fade(0))
            yield return null;
            fadeImage.gameObject.SetActive(false);
    }

    private bool Fade(float target)
    {
    fadeImage.CrossFadeAlpha(target, fadeTime, true);
    if(Mathf.Abs(fadeImage.canvasRenderer.GetAlpha() - target) <= 0.05f)
    {
        fadeImage.canvasRenderer.SetAlpha(target);
        return true;
    }
    return false;
    }
}
