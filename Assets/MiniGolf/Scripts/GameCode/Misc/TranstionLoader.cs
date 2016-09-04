using System.Collections;
using UnityEngine;

/// <summary>
/// Transtion loader.
/// </summary>
public class TranstionLoader : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Gameplay.LoadScene(Constants.getLastSceneIndex());
    }
}
