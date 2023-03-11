using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace EndlessRunner.Inputs
{
    public class InputReader : IInputReader
    {
        private PlayerInput playerInput;
        
        public float Horizontal { get; private set; }
        public bool IsJump { get; private set; }


        public InputReader(PlayerInput playerInput)
        {
            this.playerInput = playerInput;
            
            playerInput.currentActionMap.actions[0].performed += OnHorizontalMovement; 
            playerInput.currentActionMap.actions[1].started += OnJump;
            playerInput.currentActionMap.actions[1].canceled += OnJump;
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            IsJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMovement(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }
}


