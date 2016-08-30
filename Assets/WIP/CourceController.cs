using System.Collections;
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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
