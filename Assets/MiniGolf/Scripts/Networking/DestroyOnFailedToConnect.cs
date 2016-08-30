//#define PHOTON_MULTIPLAYER
using System.Collections;
using UnityEngine;

public class DestroyOnFailedToConnect : MonoBehaviour
{

    public void Awake()
    {
        #if PHOTON_MULTIPLAYER
        #else
        Destroy(gameObject);

        #endif
    }
    // Use this for initialization
    public void OnFailedToConnectToPhoton()
    {
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
