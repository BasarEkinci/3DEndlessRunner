using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Movements;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class VerticalMovement : IMover
    {
        IEntityController entityController;
        private float moveSpeed;
        
        public VerticalMovement(IEntityController entityController)
        {
            this.entityController = entityController;
            //moveSpeed = entityController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            entityController.Transform.Translate(Vector3.back * (vertical * moveSpeed * Time.deltaTime));
        }
    }
}


