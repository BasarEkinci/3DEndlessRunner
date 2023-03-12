using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Inputs;
using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Inputs;
using EndlessRunner.Managers;
using EndlessRunner.Movements;
using UnityEngine;
using UnityEngine.InputSystem;


namespace EndlessRunner.Controllers
{
    public class PlayerController : MyCharacterController,IEntityController
    {
        private float jumpForce = 3000f;
        public Transform Transform { get; set; }
        private IMover mover;
        private IJump jump;
        private IInputReader input;
        private float horizontal;
        private bool isJump;
        private bool isDead = false;
        private void Awake()
        {
            mover = new HorizontalMovement(this);
            jump = new JumpWithRb(this);
            input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            if(isDead) return;
            
            horizontal = input.Horizontal;
            if (input.IsJump)
            {
                isJump = true;
            }
        }

        private void FixedUpdate()
        {
            mover.FixedTick(horizontal);

            if (isJump)
            {
                jump.FixedTick(jumpForce);
            }
            isJump = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            IEntityController entityController = other.GetComponent<IEntityController>();
            if (entityController != null)
            {
                isDead = true;
                GameManager.Instance.StopGame();
            }
        }
    }
}


