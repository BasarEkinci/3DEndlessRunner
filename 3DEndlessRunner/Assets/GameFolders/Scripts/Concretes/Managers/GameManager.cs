using System;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Abstracts.Utilities;
using UnityEngine;

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
        
        public void LoadScene()
        {
                     
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }    
}


