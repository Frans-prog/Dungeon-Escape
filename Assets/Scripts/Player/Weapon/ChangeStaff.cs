using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;

public class ChangeStaff : MonoBehaviour
{
    private GameObject Mage,WoodenStaff,SapphireStaff,GlacialStaff,EagleStarStaff;
    public UnityEvent buttonClick;

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
        Mage = GameObject.Find("/Player/Mage");
        WoodenStaff = GameObject.Find("/Player/Mage/StaffsParent/WoodenStaff");
        SapphireStaff = GameObject.Find("/Player/Mage/StaffsParent/SapphireStaff");
        GlacialStaff = GameObject.Find("/Player/Mage/StaffsParent/GlacialStaff");
        EagleStarStaff = GameObject.Find("/Player/Mage/StaffsParent/EagleStarStaff");
    }

    public void EquipWoodenStaff()
    {
         if(Mage != null)
        {
            WoodenStaff.gameObject.SetActive(true);
            SapphireStaff.gameObject.SetActive(false);
            GlacialStaff.gameObject.SetActive(false);
            EagleStarStaff.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Staff Changed to Wooden");
        }
        else
        {
            Debug.Log("Unable to change staff");
        }
    }

     public void EquipSapphireStaff()
    {
         if(Mage != null)
        {
            WoodenStaff.gameObject.SetActive(false);
            SapphireStaff.gameObject.SetActive(true);
            GlacialStaff.gameObject.SetActive(false);
            EagleStarStaff.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Staff Changed to Sapphire");
        }
        else
        {
            Debug.Log("Unable to change staff");
        }
    }

     public void EquipGlacialStaff()
    {
         if(Mage != null)
        {
            WoodenStaff.gameObject.SetActive(false);
            SapphireStaff.gameObject.SetActive(false);
            GlacialStaff.gameObject.SetActive(true);
            EagleStarStaff.gameObject.SetActive(false);
            buttonClick.Invoke();
            Debug.Log("Staff Changed to Glacial");
        }
        else
        {
            Debug.Log("Unable to change staff");
        }
    }

     public void EquipEagleStarStaff()
    {
         if(Mage != null)
        {
            WoodenStaff.gameObject.SetActive(false);
            SapphireStaff.gameObject.SetActive(false);
            GlacialStaff.gameObject.SetActive(false);
            EagleStarStaff.gameObject.SetActive(true);
            buttonClick.Invoke();
            Debug.Log("Staff Changed to EagleStar");
        }
        else
        {
            Debug.Log("Unable to change staff");
        }
    }


}
