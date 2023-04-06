using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Nexan_Fight_Club
{
    public class Place_Bets : MonoBehaviour
    {
        #region Variables

        [SerializeField] Button playButton;
        #endregion
        private void Awake()
        {
           // Hide();
        }
        private void Update()
        {
            
        }

        private void Hide()
        {
            gameObject.SetActive(false);//hiding the place bets window
        }
    }

}
