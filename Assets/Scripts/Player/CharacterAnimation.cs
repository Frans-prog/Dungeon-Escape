using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public VariableJoystick  variableJoystick;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CharacterLookDirection();
    }

    void CharacterLookDirection()
    {
        if(variableJoystick.Horizontal != 0)
            {
              animator.SetBool("Walking", true);
            //hardcode ng sprite rotation para hindi na magblend tree
                if(variableJoystick.Horizontal > 0)
                {
                    transform.rotation = Quaternion.Euler(0,0,0);
                }
                else if(variableJoystick.Horizontal < 0)
                {
                    transform.rotation = Quaternion.Euler(0,180,0);
                }
            }
            else
            {
                animator.SetBool("Walking", false);
            }
    }
}
