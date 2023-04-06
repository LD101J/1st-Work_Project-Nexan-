using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Nexan_Fight_Club
{
    public class Play_Button : MonoBehaviour
    {
        public void NextScene() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Next Scene");
        }
        void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
