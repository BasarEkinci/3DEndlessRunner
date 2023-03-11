using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Movements;
using UnityEngine;

namespace EndlessRunner.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float horizontalDirection = 0f;
        [SerializeField] private float jumpForce = 3000f;
        [SerializeField] private bool isJump;
        
        private HorizontalMovement horizontelMovement;
        private JumpWithRb jump;
        
        private void Awake()
        {
            horizontelMovement = new HorizontalMovement(this);
            jump = new JumpWithRb(this);
        }

        private void FixedUpdate()
        {
            horizontelMovement.TickFixed(horizontalDirection,moveSpeed);

            if (isJump)
            {
                jump.TickFixed(jumpForce);
            }
            isJump = false;
        }
    }
}


