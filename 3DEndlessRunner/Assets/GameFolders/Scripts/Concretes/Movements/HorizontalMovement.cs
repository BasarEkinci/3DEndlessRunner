using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class HorizontalMovement
    {
        private PlayerController playerController;

        public HorizontalMovement(PlayerController playerController)
        {
            this.playerController = playerController;
        }

        public void TickFixed(float horizontal,float moveSpeed)
        {
            if (horizontal == 0)
                return;
            
            playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * moveSpeed);
        }
    }
}


