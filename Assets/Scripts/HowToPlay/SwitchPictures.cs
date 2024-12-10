using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPictures : MonoBehaviour
{
   
    public GameObject[] background;
    int index;

    void Start()
    {
        index = 0;
    }
        

    void Update()
    {
        if(index >= 4)
           index = 4 ; 

        if(index < 0)
           index = 0 ;
        


        if(index == 0)
        {
            background[0].gameObject.SetActive(true);
        }
        
    }

    public void Next()
{
    index += 1;

    if (index >= background.Length) // check if index is greater than or equal to the length of the array
    {
        index = 0; // set index to 0 to cycle back to the beginning of the array
    }

    for (int i = 0; i < background.Length; i++)
    {
        background[i].gameObject.SetActive(false);
    }

    background[index].gameObject.SetActive(true);

    Debug.Log(index);
}

public void Previous()
{
    index -= 1;

    if (index < 0) // check if index is less than 0
    {
        index = background.Length - 1; // set index to the last element of the array to cycle back to the end of the array
    }

    for (int i = 0; i < background.Length; i++)
    {
        background[i].gameObject.SetActive(false);
    }

    background[index].gameObject.SetActive(true);

    Debug.Log(index);
}

   
}