using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourceController : MonoBehaviour
{
    public enum GameDiffuculties
    {
        Easy,
        Intermediate,
        Hard,
        Challanging
    }

    public enum GameLengths
    {
        Short,
        Regular,
        Long
    }

    public GameDiffuculties gameDiffuculty;

    public GameLengths numberOfHoles;

    public GameObject[] myCource;

    public GameObject[] easyCources;
    public GameObject[] intermediateCources;
    public GameObject[] hardCources;
    public GameObject[] challangingCources;

    Transform parentGO;
    GameObject currentHole;

    // Use this for initialization
    void OnEnable()
    {
        parentGO = this.gameObject.transform;
        LoadCourse(0);
    }

    void LoadCourse(int courceNumber)
    {
        currentHole = Instantiate(myCource[0].gameObject,parentGO) as GameObject;
    }

    void DestoryCourse()
    {
        DestroyImmediate(currentHole);
    }
}
