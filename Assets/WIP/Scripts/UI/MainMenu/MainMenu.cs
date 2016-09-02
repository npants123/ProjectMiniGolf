using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void LoadScene(string sceneName)
    {
        Utility.LoadScene(sceneName);
    }

    public void Options()
    {
        Debug.Log("ShowOptions");
    }


}
