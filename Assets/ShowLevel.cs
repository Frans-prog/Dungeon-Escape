using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLevel : MonoBehaviour
{
 public GameObject uiObject;
  public float displayTime = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiObject.SetActive(true);
             StartCoroutine(HideUIText());
        }
    }

    IEnumerator HideUIText()
    {
        yield return new WaitForSeconds(displayTime);
        uiObject.SetActive(false);
        Destroy(gameObject);
    }
}