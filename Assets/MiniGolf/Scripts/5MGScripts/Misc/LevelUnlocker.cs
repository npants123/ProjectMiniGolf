using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace FMG
{
    public class LevelUnlocker : MonoBehaviour
    {
        public Text levelText;
        // Use this for initialization
        void Start()
        {
            //levelText.text = "Unlock level: " + Application.loadedLevel;
            levelText.text = "Unlock level: " + Gameplay.CurrentSceneIndex;
            //if (Application.loadedLevel < Constants.getMaxLevel())
            if (Gameplay.CurrentSceneIndex < Constants.getMaxLevel())
            {
                levelText.color = Color.blue;
                Destroy(gameObject);
            }
        }

        public void unlock()
        {
            //int nextMaxLevel = Application.loadedLevel + 1;
            int nextMaxLevel = Gameplay.CurrentSceneIndex + 1;
            Constants.setMaxLevel(nextMaxLevel);
            Debug.Log("unlock" + nextMaxLevel);
            Destroy(gameObject);
        }
    }
}