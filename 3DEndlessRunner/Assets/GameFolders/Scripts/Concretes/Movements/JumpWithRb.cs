using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class JumpWithRb : IJump
    {
        private Rigidbody playerRb;
        public bool CanJump => playerRb.velocity.y != 0f;

        public JumpWithRb(PlayerController playerController)
        {
            playerRb = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float jumpForce)
        {
            if (CanJump) return;
            
            playerRb.velocity = Vector3.zero;
            playerRb.AddForce(Vector3.up * (Time.deltaTime * jumpForce));
        }
    }
}

