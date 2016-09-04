using System.Collections;
using UnityEngine;

public class DisableIfNoNextLevel : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        if (Gameplay.CurrentSceneIndex + 1 >=  Gameplay.SceneCount)
        {
            Destroy(gameObject);
        }
    }
}
