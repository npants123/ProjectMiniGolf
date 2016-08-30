using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FMG
{
    public class LevelButton : MonoBehaviour
    {
        public int levelIndex = 0;

        public void onClick()
        {
            //Application.LoadLevel(levelIndex);
            SceneManager.LoadScene(levelIndex);
        }
    }
}