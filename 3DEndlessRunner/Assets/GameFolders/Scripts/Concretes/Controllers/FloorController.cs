using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace EndlessRunner.Controllers
{
    public class FloorController : MonoBehaviour
    {
        private Material material;
        [SerializeField] private float moveSpeed;

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


