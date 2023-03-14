using System;
using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Inputs;
using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Inputs;
using EndlessRunner.Managers;
using EndlessRunner.Movements;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;


namespace EndlessRunner.Controllers
{
    public class PlayerController : MyCharacterController,IEntityController
    {
        [SerializeField] private float jumpForce = 1500f;

        IMover _mover;
        private IJump _jump;
        IInputReader _input;
        float _horizontal;
        bool _isJump;
        bool _isDead = false;

        private void Awake()
        {
            _mover = new HorizontalMovement(this);
            _input = new InputReader(GetComponent<PlayerInput>());
            _jump = new JumpWithRb(this);
        }


        void Update()
        {
            if (_isDead) return;
            
            _horizontal = _input.Horizontal;
            
            if (_input.IsJump)
            {
                _isJump = true;
            }

        }

        private void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jump.FixedTick(jumpForce);
            }
            _isJump = false;
        }

        void OnTriggerEnter(Collider other)
        {
            IEntityController entityController = other.GetComponent<IEntityController>();

            if (entityController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }
        }
    }
}


