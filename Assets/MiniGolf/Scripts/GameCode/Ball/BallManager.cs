using System.Collections;
using UnityEngine;

/// <summary>
/// Ball manager.
/// </summary>
public class BallManager : MonoBehaviour
{
    public delegate void EnterState(string stateID);

    public static event EnterState onEnterState;

    public static void enterState(string stateID)
    {
        if (onEnterState != null)
        {
            onEnterState(stateID);
        }
    }
}
