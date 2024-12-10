using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";

    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;

    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        //Default Values when starting the game
        if(firstPlayInt == 0)
        {
            backgroundFloat = .289f;
            soundEffectsFloat = .75f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            //It till only do the intial value one time
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
    }

        public void SaveSoundSettings()
        {
            PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);
        }
        // It will save the settings regardless if you exit the game.
        void OnApplicationFocus(bool inFocus) 
        {
            if(!inFocus)
            {
                SaveSoundSettings();
            }
        }
        public void UpdateSound()
        {
            backgroundAudio.volume = backgroundSlider.value;

            for(int i = 0; i< soundEffectsAudio.Length; i++)
            {
                soundEffectsAudio[i].volume = soundEffectsSlider.value;
            }
        }
 
   
}
