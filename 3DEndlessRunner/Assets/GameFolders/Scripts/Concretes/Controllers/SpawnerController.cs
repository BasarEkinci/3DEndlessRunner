using EndlessRunner.Enums;
using EndlessRunner.Managers;
using EndlessRunner.UIs;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EndlessRunner.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        private float min = 1f;
        private float max = 15f;
        
        private int index;
        private float maxAddEnemyTime;

        public bool CanIncrease => index < EnemyManger.Instance.Count;
        
        private void OnEnable()
        {
            RandomTimer();
        }

        private float maxSpawnTime = 10f;
        private float currentSpawnTime;
        private void Update()
        {
            
            SetDifficulty();
            
            currentSpawnTime += Time.deltaTime;

            if (currentSpawnTime > maxSpawnTime)
            {
                Spawn();
            }

            if (!CanIncrease) return;
            
            if (maxAddEnemyTime < Time.time)
            {
                maxAddEnemyTime = Time.time + EnemyManger.Instance.AddDelayTime;
                IncreaseIndex();
            }
            Debug.Log("Max Spawn Time: " + max);
            Debug.Log("Min Spawn Time: " + min);
        }

        void IncreaseIndex()
        {
            if (CanIncrease)
            {
                index++;
            }
        }

        void Spawn()
        {
            EnemyController newEnemy = EnemyManger.Instance.GetPool((EnemyEnum)Random.Range(0,index));
            ((Component)newEnemy).transform.parent = this.transform;
            ((Component)newEnemy).transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);
            
            currentSpawnTime = 0;
            RandomTimer();
            
        }

        private void RandomTimer()
        {
            maxSpawnTime = Random.Range(min, max);
        }

        void SetDifficulty()
        {
            if (GameManager.Instance.CurrentTime <= 10f)
            {
                max = 15;
            }
            else if (GameManager.Instance.CurrentTime <= 20f)
            {
                max = 8;
            }
            else if (GameManager.Instance.CurrentTime <= 30f)
            {
                max = 3;
            }
            else
            {
                max = 1.5f;
            }
        }
    }
}


