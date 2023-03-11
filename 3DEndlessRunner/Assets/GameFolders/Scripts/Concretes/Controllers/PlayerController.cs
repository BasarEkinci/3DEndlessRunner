using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Inputs;
using EndlessRunner.Inputs;
using EndlessRunner.Movements;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace EndlessRunner.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float jumpForce = 3000f;

        private HorizontalMovement horizontelMovement;
        private JumpWithRb jump;
        private IInputReader input;
        private float horizontal;
        private bool isJump;
        
        private void Awake()
        {
            horizontelMovement = new HorizontalMovement(this);
            jump = new JumpWithRb(this);
            input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            horizontal = input.Horizontal;
            if (input.IsJump)
            {
                isJump = true;
            }
        }

        private void FixedUpdate()
        {
            horizontelMovement.TickFixed(horizontal,moveSpeed);

            if (isJump)
            {
                jump.TickFixed(jumpForce);
            }
            isJump = false;
        }
    }
}


