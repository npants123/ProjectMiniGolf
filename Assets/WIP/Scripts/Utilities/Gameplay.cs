//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

#if UNITY_5_4_OR_NEWER
using UnityEngine.SceneManagement;
#endif

public class Gameplay
{

    public static string Version = "0.0.0";
    public static string PlayerName = "Player";

    public static bool IsMultiplayer = false;
    protected static bool m_IsMaster = true;

    /// <summary>
    /// this property can be set by multiplayer scripts to assign master status
    /// to the local player. in singleplayer this is forced to true
    /// </summary>
    public static bool IsMaster
    {
        get
        {
            if (!IsMultiplayer)
                return true;
            return m_IsMaster;
        }
        set
        {
            if (!IsMultiplayer)
                return;
            m_IsMaster = value;
        }
    }


    /// <summary>
    /// pauses or unpauses the game by means of setting timescale to zero. will
    /// backup the current timescale for when the game is unpaused.
    /// NOTE: will not work in multiplayer
    /// </summary>
    public static bool IsPaused
    {
        get { return TimeUtility.Paused; }
        set { TimeUtility.Paused = (Gameplay.IsMultiplayer ? false : value); }
    }

}