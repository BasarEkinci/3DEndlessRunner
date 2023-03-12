using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Movements;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class HorizontalMovement : IMover
    {
        IEntityController entityController;

        public HorizontalMovement(IEntityController entityController)
        {
            this.entityController = entityController;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;

            entityController.transform.Translate(Vector3.right * (horizontal * Time.deltaTime * entityController.MoveSpeed));

            float xBoundary = Mathf.Clamp(entityController.transform.position.x, -entityController.MoveBoundary, entityController.MoveBoundary);
            entityController.transform.position = new Vector3(xBoundary, entityController.transform.position.y, 0f);
        }
    } 
    
}


