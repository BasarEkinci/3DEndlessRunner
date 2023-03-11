using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class JumpWithRb
    {
        private Rigidbody playerRb;

        public JumpWithRb(PlayerController playerController)
        {
            playerRb = playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float jumpForce)
        {
            if (playerRb.velocity.y != 0) return;
                
            
            playerRb.velocity = Vector3.zero;
            playerRb.AddForce(Vector3.up * (Time.deltaTime * jumpForce));
        }
    }
}

