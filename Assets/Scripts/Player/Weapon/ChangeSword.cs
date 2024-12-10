using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class ChangeSword : MonoBehaviour
{
    private GameObject Warrior,IronSword,SapphireSword,GlacialKatana,EagleStarSword;
    public UnityEvent buttonClick;
   
    //public GameObject gameObject;

    void Start()
    {
        Warrior = GameObject.Find("/Player/Warrior");
        IronSword = GameObject.Find("/Player/Warrior/SwordParent/IronSword");
        SapphireSword = GameObject.Find("/Player/Warrior/SwordParent/SapphireSword");
        GlacialKatana = GameObject.Find("/Player/Warrior/SwordParent/GlacialKatana");
        EagleStarSword = GameObject.Find("/Player/Warrior/SwordParent/EagleStarSword");
        
    }
    void Awake()
    {
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }
    }

    public void EquipIronSword()
    {
        if(Warrior != null)
        {
            IronSword.gameObject.SetActive(true);
            SapphireSword.gameObject.SetActive(false);
            GlacialKatana.gameObject.SetActive(false);
            EagleStarSword.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Sword Changed to Iron");
        }
        else
        {
            Debug.Log("Unable to change sword");
        }
    }

    public void EquipSapphireSword()
    {
        if(Warrior != null)
        {
            IronSword.gameObject.SetActive(false);
            SapphireSword.gameObject.SetActive(true);
            GlacialKatana.gameObject.SetActive(false);
            EagleStarSword.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Sword Changed to Sapphire");
        }
        else
        {
            Debug.Log("Unable to change sword");
        }
    }

    public void EquipGlacialKatana()
    {
        if(Warrior != null)
        {
            IronSword.gameObject.SetActive(false);
            SapphireSword.gameObject.SetActive(false);
            GlacialKatana.gameObject.SetActive(true);
            EagleStarSword.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Sword Changed to Glacial Katana");
        }
        else
        {
            Debug.Log("Unable to change sword");
        }
    }

    public void EquipEagleStarSword()
    {
        if(Warrior != null)
        {
            IronSword.gameObject.SetActive(false);
            SapphireSword.gameObject.SetActive(false);
            GlacialKatana.gameObject.SetActive(false);
            EagleStarSword.gameObject.SetActive(true);
            
            Debug.Log("Sword Changed to Eagle Star");
        }
        else
        {
            Debug.Log("Unable to change sword");
        }
    }
    
}
