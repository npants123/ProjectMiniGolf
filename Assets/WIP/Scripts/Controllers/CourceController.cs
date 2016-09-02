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

    // The diffulty the user selected
    public GameDiffuculties gameDiffuculty;

    // This will be generated based on the diffulty selected using the 4 arrys below
    public GameObject[] myCource;

    // Differnt COuse to chose from based on the diffulty selected 
    public GameObject[] easyCources;
    public GameObject[] intermediateCources;
    public GameObject[] hardCources;
    public GameObject[] challangingCources;
    // End diffuly

    // How many holes the couse will be made up of
    public static int numberOfHoles = 18;

    // Current hole int in the index
    int currentHoleIndex;

    // this will be the parent of the current hole
    Transform parentGO;

    // Ref for the current GizmoDrawHole prefab
    GameObject currentHole;

    // Use this for initialization
    void OnEnable()
    {
        parentGO = this.gameObject.transform;
        numberOfHoles = 18;
        currentHoleIndex = 0;
        LoadHole(currentHoleIndex);
    }

    // Will load the next hole
    void LoadNextHole ()
    {
        //destroy cvurrent hole
        DestoryCurrentHole();

        // increment the current hole int by 1
        currentHoleIndex++;

        if (currentHoleIndex < numberOfHoles)
        {
            // Load the next hole
            LoadHole(currentHoleIndex);
        }
        else
        {
            // No more holes show game over
            GameOver();
        }
    }

    void GameOver()
    {
        // TODO do something else besides debug here
        Debug.Log("GameOver");
    }

    // Loads a hole from an arry
    void LoadHole(int holeIndex)
    {
        currentHole = Instantiate(myCource[holeIndex].gameObject,parentGO) as GameObject;
    }

    // will destroy the current hole game object
    void DestoryCurrentHole()
    {
        DestroyImmediate(currentHole);
    }
}
