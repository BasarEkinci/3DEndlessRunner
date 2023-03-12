using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

namespace EndlessRunner.UIs
{
    public class TimeCounter : MonoBehaviour
    {
        private TMP_Text text;
        private float currentTime;
        private void Awake()
        {
            text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            currentTime += Time.deltaTime;
            text.text = "Time: " + currentTime.ToString("0");
        }
    }    
}


