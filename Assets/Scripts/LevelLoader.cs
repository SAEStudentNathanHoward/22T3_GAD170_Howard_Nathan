using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NathanHoward
{
    public class LevelLoader : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                LoadLevel("Activities - Week 02");
            }
        }
        /// <summary>
        /// This will be the method that loads a scene
        /// </summary>
        private void LoadLevel(string sceneToLoad)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}