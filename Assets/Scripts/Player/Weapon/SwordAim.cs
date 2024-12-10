using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAim : MonoBehaviour
{
   public VariableJoystick variableJoystick;
   public float angle;
   

    // Update is called once per frame
    void Update()
    {
        RotateWeapon();
    }
    
    void RotateWeapon()
    {
        
        if(variableJoystick.Direction == Vector2.zero) return;
        angle = Mathf.Atan2(variableJoystick.Vertical, variableJoystick.Horizontal) * Mathf.Rad2Deg;
        var lookRotation = Quaternion.Euler(angle * Vector3.forward);
        transform.rotation = lookRotation;
        
        Vector2 scale = transform.localScale;
        if(variableJoystick.Horizontal < 0)
        {
            scale.y = -1;
        }
        else if(variableJoystick.Horizontal > 0)
        {
            scale.y = 1;
        }
        transform.localScale = scale;
    }
}
