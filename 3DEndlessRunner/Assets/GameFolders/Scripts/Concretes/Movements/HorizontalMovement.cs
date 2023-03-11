using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class HorizontalMovement
    {
        private PlayerController playerController;
        private float moveSpeed;
        private float moveBoundary;

        public HorizontalMovement(PlayerController playerController)
        {
            this.playerController = playerController;
            moveSpeed = playerController.MoveSpeed;
            moveBoundary = playerController.MoveBoundary;
        }

        public void TickFixed(float horizontal)
        {
            if (horizontal == 0)
                return;
            
            playerController.transform.Translate(Vector3.right * (horizontal * Time.deltaTime * moveSpeed));

            float xBoundary = Mathf.Clamp(playerController.transform.position.x,-moveBoundary,moveBoundary);
            playerController.transform.position = new Vector3(xBoundary, playerController.transform.position.y, 0);
        }
    }
}


