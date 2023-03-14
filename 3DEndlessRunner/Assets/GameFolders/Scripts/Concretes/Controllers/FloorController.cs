using EndlessRunner.Managers;
using UnityEngine;

namespace EndlessRunner.Controllers
{
    public class FloorController : MonoBehaviour
    {
        private Material material;
        private float timer;
        private float moveSpeed = 0.6f;
        private void Awake()
        {
            material = GetComponentInChildren<MeshRenderer>().material;
        }

        private void Update()
        {
            material.mainTextureOffset += Vector2.down * (Time.deltaTime * moveSpeed);
        }
        
    }
}


