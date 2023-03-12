using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Managers;
using UnityEngine;

namespace EndlessRunner.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameOverPanel gameOverPanel;

        private void Awake()
        {
            gameOverPanel.gameObject.SetActive(false);
        }
        
        private void HandleOnGameStop()
        {
            gameOverPanel.gameObject.SetActive(true);
        }
        
        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;
        }
        
        
    }    
}


