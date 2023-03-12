using System.Collections.Generic;
using EndlessRunner.Abstracts.Utilities;
using EndlessRunner.Controllers;
using UnityEngine;

namespace EndlessRunner.UIs
{
    public class EnemyManger : SingeltonMonoBehaviorObject<EnemyManger>
    {
        [SerializeField] private EnemyController[] enemyPrefabs;

        private Queue<EnemyController> enemies = new Queue<EnemyController>();

        private void Awake()
        {
            SingeltonThisObject(this);
        }

        private void Start()
        {
            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 0; i < 10; i++)
            {
                EnemyController newEnemy = Instantiate(enemyPrefabs[Random.Range(0,enemyPrefabs.Length)]);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = this.transform;
                enemies.Enqueue(newEnemy);
            }
        }

        public void SetPool(EnemyController enemyController)
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = this.transform;
            enemies.Enqueue(enemyController);
        }

        public EnemyController GetPool()
        {
            if (enemies.Count == 0)
            {
                InitializePool();
            }
            return enemies.Dequeue();
        }
    }    
}


