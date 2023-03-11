using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Managers;
using UnityEngine;

namespace EndlessRunner.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene();
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }


    }
}

