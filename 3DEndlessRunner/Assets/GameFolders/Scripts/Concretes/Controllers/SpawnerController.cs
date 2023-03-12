using EndlessRunner.UIs;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EndlessRunner.Controllers
{
    public class SpawnerController : MonoBehaviour
    {

        
        [Range(0.1f,5f)] [SerializeField] private float min = 0.1f;
        [Range(6f,15f)] [SerializeField] private float max = 15f;
        private void OnEnable()
        {
            RandomTimer();
        }

        private float maxSpawnTime = 10f;
        private float currentSpawnTime;
        private void Update()
        {
            currentSpawnTime += Time.deltaTime;

            if (currentSpawnTime > maxSpawnTime)
            {
                Spawn();
            }
        }

        void Spawn()
        {
            EnemyController newEnemy = EnemyManger.Instance.GetPool();
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);
            
            currentSpawnTime = 0;
            RandomTimer();
        }

        private void RandomTimer()
        {
            maxSpawnTime = Random.Range(min, max);
        }
    }
}


