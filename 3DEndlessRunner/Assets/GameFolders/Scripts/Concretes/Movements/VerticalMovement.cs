using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class VerticalMovement : MonoBehaviour
    {
        private EnemyController enemyController;
        private float moveSpeed;
        
        public VerticalMovement(EnemyController enemyController)
        {
            this.enemyController = enemyController;
            moveSpeed = enemyController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            enemyController.transform.Translate(Vector3.back * (vertical * moveSpeed * Time.deltaTime));
        }
    }
}


