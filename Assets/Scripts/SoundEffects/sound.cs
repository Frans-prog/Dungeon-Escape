using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    [Header ("Sound Manager")]
    public AudioSource audioSource;
    public AudioClip attack_Sfx, openbag_Sfx, switchchar_Sfx,walking_Sfx;

    public void attack_btn()
    {
        audioSource.clip = attack_Sfx;
        audioSource.Play();
    }
    public void open_inventory()
    {
        audioSource.Stop();
        audioSource.clip = openbag_Sfx;
        audioSource.Play();
    }
    public void char_switch()
    {
        audioSource.Stop();
        audioSource.clip = switchchar_Sfx;
        audioSource.Play();
    }
    public void walking_SFX()
    {
        audioSource.Stop();
        audioSource.clip = walking_Sfx;
        audioSource.Play();
    }

    // Start is called before the first frame update
}