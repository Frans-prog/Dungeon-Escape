using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class ChangeBow : MonoBehaviour
{
    private GameObject Archer,WoodenBow,SapphireBow,GlacialBow,EagleStarBow;
    public UnityEvent buttonClick;
    // Start is called before the first frame update
    void Awake()
    {
        if(buttonClick == null) 
        {
            buttonClick = new UnityEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Archer = GameObject.Find("/Player/Archer");
        WoodenBow = GameObject.Find("/Player/Archer/BowsParent/WoodenBow");
        SapphireBow = GameObject.Find("/Player/Archer/BowsParent/SapphireBow");
        GlacialBow = GameObject.Find("/Player/Archer/BowsParent/GlacialBow");
        EagleStarBow = GameObject.Find("/Player/Archer/BowsParent/EagleStarBow");

    }

    public void EquipWoodenBow()
    {
        if(Archer != null)
        {
            WoodenBow.gameObject.SetActive(true);
            SapphireBow.gameObject.SetActive(false);
            GlacialBow.gameObject.SetActive(false);
            EagleStarBow.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Bow Changed to Wooden");
        }
        else
        {
            Debug.Log("Unable to change bow");
        }
    }

    public void EquipSapphireBow()
    {
        if(Archer != null)
        {
            WoodenBow.gameObject.SetActive(false);
            SapphireBow.gameObject.SetActive(true);
            GlacialBow.gameObject.SetActive(false);
            EagleStarBow.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Bow Changed to Sapphire");
        }
        else
        {
            Debug.Log("Unable to change bow");
        }
    }

    public void EquipGlacialBow()
    {
        if(Archer != null)
        {
            WoodenBow.gameObject.SetActive(false);
            SapphireBow.gameObject.SetActive(false);
            GlacialBow.gameObject.SetActive(true);
            EagleStarBow.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Bow Changed to Glacial");
        }
        else
        {
            Debug.Log("Unable to change bow");
        }
    }

    public void EquipEagleStarBow()
    {
        if(Archer != null)
        {
            WoodenBow.gameObject.SetActive(false);
            SapphireBow.gameObject.SetActive(false);
            GlacialBow.gameObject.SetActive(false);
            EagleStarBow.gameObject.SetActive(true);
            buttonClick.Invoke();
            Debug.Log("Bow Changed to Eagle Star");
        }
        else
        {
            Debug.Log("Unable to change bow");
        }
    }

}
