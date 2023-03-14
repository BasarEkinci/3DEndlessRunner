using System;
using System.Collections;
using EndlessRunner.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EndlessRunner.Managers
{
    public class GameManager : SingeltonMonoBehaviorObject<GameManager>
    {

        private float currentTime;
        private float moveSpeed;

        public float CurrentTime => currentTime;
        public event System.Action OnGameStop;
        
        private void Awake()
        {
            SingeltonThisObject(this);
        }

        private void Update()
        {
            currentTime += Time.deltaTime;
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
            OnGameStop?.Invoke();
        }
        
        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
            Time.timeScale = 1f;
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }    
}


