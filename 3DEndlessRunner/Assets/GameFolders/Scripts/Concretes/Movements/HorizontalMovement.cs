using System;
using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Movements;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class HorizontalMovement : IMover
    {
        IEntityController entityController;

        private float moveSpeed;
        
        public HorizontalMovement(IEntityController entityController)
        {
            this.entityController = entityController;
        }
        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;

            entityController.transform.Translate(Vector3.right * (horizontal * Time.deltaTime * moveSpeed));

            float xBoundary = Mathf.Clamp(entityController.transform.position.x, -entityController.MoveBoundary, entityController.MoveBoundary);
            entityController.transform.position = new Vector3(xBoundary, entityController.transform.position.y, 0f);
        }
    } 
    
}


