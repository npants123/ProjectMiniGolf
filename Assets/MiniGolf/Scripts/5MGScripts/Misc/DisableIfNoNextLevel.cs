using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableIfNoNextLevel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (SceneManagerHelper.ActiveSceneBuildIndex + 1 >= SceneManager.sceneCount)
        {
            Destroy(gameObject);
        }
    }
}
