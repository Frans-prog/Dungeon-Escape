using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Events;


[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
        public float playerSpeed;
        private Rigidbody2D rb;
        [SerializeField] VariableJoystick variableJoystick; 
        private Animator animator;
        public UnityEvent buttonClick;
    
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponentInChildren<Rigidbody2D>();
        }
    
        // Update is called once per frame
        void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            rb.velocity = new Vector2(variableJoystick.Horizontal * playerSpeed, variableJoystick.Vertical * playerSpeed);
         }

        }
        
        


