using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner.Abstracts.Utilities
{
    public class SingeltonMonoBehaviorObject<T> : MonoBehaviour where T:Component
    {
        public static T Instance { get; private set; }

        protected void SingeltonThisObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}


