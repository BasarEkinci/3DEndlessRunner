using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Managers;
using UnityEngine;


namespace EndlessRunner.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void TryAgainButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void ReturnMainMenuButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }
    }

}

