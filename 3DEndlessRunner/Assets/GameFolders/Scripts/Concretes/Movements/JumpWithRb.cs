using System;
using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class JumpWithRb : IJump
    {
        Rigidbody _rigidbody;

        public bool CanJump => _rigidbody.velocity.y != 0f;

        public JumpWithRb(PlayerController playerController)
        {
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float jumpForce)
        {
            if (CanJump) return;

            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * (Time.deltaTime * jumpForce));
        }

    }
}

