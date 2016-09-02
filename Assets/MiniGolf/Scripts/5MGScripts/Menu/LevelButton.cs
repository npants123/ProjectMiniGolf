using System.Collections;
using UnityEngine;

namespace FMG
{
    public class LevelButton : MonoBehaviour
    {
        public int levelIndex = 0;

        public void onClick()
        {
            Utility.LoadScene(levelIndex);
        }
    }
}