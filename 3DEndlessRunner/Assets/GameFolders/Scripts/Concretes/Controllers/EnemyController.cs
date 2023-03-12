using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Movements;
using EndlessRunner.UIs;
using UnityEngine;


namespace EndlessRunner.Controllers
{
    public class EnemyController : MyCharacterController,IEntityController
    {
        [SerializeField] private float lifeTime = 10f;
        
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

