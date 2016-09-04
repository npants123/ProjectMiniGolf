using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public void QuitGame()
    {
        Gameplay.Quit();
    }

    public void LoadScene(string sceneName)
    {
        Gameplay.LoadScene(sceneName);
    }

    public void Options()
    {
        Debug.Log("ShowOptions");
    }


}
