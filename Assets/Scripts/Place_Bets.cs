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
        [SerializeField] private string enteredName; //name im entering
        [SerializeField] private GameObject inputField; //where im typing the name
        [SerializeField] private GameObject outputText; //where the text outputs
        #endregion
        public void StoreName()
        {
            enteredName = inputField.GetComponent<Text>().text;
            outputText.GetComponent<Text>().text = enteredName;
            
        }
        private void Hide()
        {
            gameObject.SetActive(false);//hiding the place bets window
        }
      
    }

}
