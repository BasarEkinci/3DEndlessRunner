using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Movements;
using EndlessRunner.UIs;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace EndlessRunner.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        private VerticalMovement verticalMovement;
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float lifeTime = 10f;

        private float currentLifeTime = 0f;
        public float MoveSpeed => moveSpeed;
        
        private void Awake()
        {
            verticalMovement = new VerticalMovement(this);
        }

        private void Update()
        {
            currentLifeTime += Time.deltaTime;

            if (currentLifeTime > lifeTime)
            {
                currentLifeTime = 0f;
                KillYourSelf();
            }
        }
        private void FixedUpdate()
        {
            verticalMovement.FixedTick();
        }
        
        private void KillYourSelf()
        {
            EnemyManger.Instance.SetPool(this);  
        }
    }
}

