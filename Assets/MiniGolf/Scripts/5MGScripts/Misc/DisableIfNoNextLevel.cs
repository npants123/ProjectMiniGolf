using System.Collections;
using UnityEngine;

public class DisableIfNoNextLevel : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        if (Utility.CurrentSceneIndex + 1 >=  Utility.SceneCount)
        {
            Destroy(gameObject);
        }
    }
}
