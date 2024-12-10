using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChangeBG : MonoBehaviour {

    // Reference to Audio Source component
    private AudioSource audioSrc;

    //Dito yung Default audio kapag nagstart yung game
    private float musicVolume = 0.2684384f;

	// Use this for initialization
	void Start () {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
	}

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
