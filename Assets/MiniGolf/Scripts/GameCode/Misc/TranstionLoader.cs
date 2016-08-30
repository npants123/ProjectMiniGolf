using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Transtion loader.
/// </summary>
public class TranstionLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Application.LoadLevel(Constants.getLastSceneIndex());
        SceneManager.LoadScene(Constants.getLastSceneIndex());
    }


}
