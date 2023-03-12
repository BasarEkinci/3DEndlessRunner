using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class HorizontalMovement : IMover
    {
        IEntityController playerController;
        float moveSpeed;
        float moveBoundary;

        public HorizontalMovement(IEntityController entityController)
        {
            playerController = entityController;
            moveSpeed = entityController.MoveSpeed;
            moveBoundary = entityController.MoveBoundary;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0)
                return;
            
            playerController.Transform.Translate(Vector3.right * (horizontal * Time.deltaTime * moveSpeed));

            float xBoundary = Mathf.Clamp(playerController.Transform.position.x,-moveBoundary,moveBoundary);
            playerController.Transform.position = new Vector3(xBoundary, playerController.Transform.position.y, 0);
        }
    }
}


