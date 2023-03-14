using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Inputs;
using EndlessRunner.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace EndlessRunner.Controllers
{
    public class AnimationController : MonoBehaviour
    {
        private Animator playerAnimator;
        private bool isJump = false;
        private void Awake()
        {
            playerAnimator = GetComponentInChildren<Animator>();
        }

        private void Start()
        {
            playerAnimator.SetBool("isJump",false);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                playerAnimator.SetBool("isJump",true);
                isJump = false;
            }
            else
            {
                playerAnimator.SetBool("isJump",false);
            }
        }
    }    
}


