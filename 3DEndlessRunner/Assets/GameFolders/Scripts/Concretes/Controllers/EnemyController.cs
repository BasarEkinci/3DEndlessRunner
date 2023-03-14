using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Enums;
using EndlessRunner.Managers;
using EndlessRunner.Movements;
using EndlessRunner.UIs;
using UnityEngine;


namespace EndlessRunner.Controllers
{
    public class EnemyController : MyCharacterController,IEntityController
    {
        private float lifeTime = 5f;
        [SerializeField] private EnemyEnum enemyEnum;
        public EnemyEnum EnemyType => enemyEnum;

        private VerticalMovement verticalMovement;
        private float currentLifeTime = 0f;
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

