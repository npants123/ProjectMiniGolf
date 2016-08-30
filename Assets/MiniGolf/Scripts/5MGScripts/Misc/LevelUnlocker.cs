using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace FMG
{
    public class LevelUnlocker : MonoBehaviour
    {
        public Text levelText;
        // Use this for initialization
        void Start()
        {

            //levelText.text = "Unlock level: " + Application.loadedLevel;
            levelText.text = "Unlock level: " + SceneManagerHelper.ActiveSceneBuildIndex;
            //if (Application.loadedLevel < Constants.getMaxLevel())
            if (SceneManagerHelper.ActiveSceneBuildIndex < Constants.getMaxLevel())
            {
                levelText.color = Color.blue;
                Destroy(gameObject);
            }
        }

        public void unlock()
        {
            //int nextMaxLevel = Application.loadedLevel + 1;
            int nextMaxLevel = SceneManagerHelper.ActiveSceneBuildIndex + 1;
            Constants.setMaxLevel(nextMaxLevel);
            Debug.Log("unlock" + nextMaxLevel);
            Destroy(gameObject);
        }
    }
}