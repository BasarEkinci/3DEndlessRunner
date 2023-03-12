using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EndlessRunner.Managers
{
    public class GameManager : SingeltonMonoBehaviorObject<GameManager>
    {
        private void Awake()
        {
            SingeltonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }
        
        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }    
}


