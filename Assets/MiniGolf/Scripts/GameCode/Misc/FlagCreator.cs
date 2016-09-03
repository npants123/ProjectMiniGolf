using System.Collections;
using UnityEngine;

/// <summary>
/// Flag creator - spawns the flag
/// </summary>
public class FlagCreator : MonoBehaviour
{

    /// <summary>
    /// The flag prefab to create
    /// </summary>
    public GameObject flagPrefab;

    GameObject tempFlagPos;
    // Use this for initialization
    public  void OnEnable()
    {
        GolfManager.onStartHole += onShowStart;
    }

    public  void OnDisable()
    {
        GolfManager.onStartHole -= onShowStart;
    }

    public void onShowStart()
    {
        if (tempFlagPos)
            DestroyImmediate(tempFlagPos);

        GameObject go = GameObject.FindWithTag("Hole");
        if (go && flagPrefab)
        {
            tempFlagPos = Instantiate(flagPrefab, go.transform.position, Quaternion.identity) as GameObject;
        }
    }

    void Start()
    {
        onShowStart();
    }
}
