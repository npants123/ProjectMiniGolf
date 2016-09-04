//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

#if UNITY_5_4_OR_NEWER
using UnityEngine.SceneManagement;
#endif

public class Gameplay
{

    public static string Version = "0.0.1";
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

    /// <summary>
    /// Tells you your curent scene's index number 'int' for the
    /// current unity version
    /// </summary>
    public static int CurrentSceneIndex
    {

        get
        {
            #if UNITY_5_4_OR_NEWER
            return SceneManager.GetActiveScene().buildIndex;
            #else
            return Application.loadedLevel;
            #endif
        }

    }

    /// <summary>
    /// Tells you your curent scene's index number 'int' for the
    /// current unity version
    /// </summary>
    public static string CurrentSceneName
    {

        get
        {
            #if UNITY_5_4_OR_NEWER
            return SceneManager.GetActiveScene().name;
            #else
            return Application.loadedLevelName;
            #endif
        }

    }

    /// <summary>
    /// Load a scene by name you specify for the
    /// current unity version
    /// </summary>
    public static void LoadScene(string sceneName)
    {

        // compile only for unity 5+
        #if (!(UNITY_4_6 || UNITY_4_5 || UNITY_4_3 || UNITY_4_2 || UNITY_4_1 || UNITY_4_0 || UNITY_3_5))
        {
            SceneManager.LoadScene(sceneName);
        }
        #else
        // compile only for unity 4.6 and older
        {

        Application.LoadScene(sceneName);
        }
        #endif

    }

    /// <summary>
    /// Load a scene by index number you specify for the
    /// current unity version
    /// </summary>
    public static void LoadScene(int sceneNumber)
    {

        // compile only for unity 5+
        #if (!(UNITY_4_6 || UNITY_4_5 || UNITY_4_3 || UNITY_4_2 || UNITY_4_1 || UNITY_4_0 || UNITY_3_5))
        {
            SceneManager.LoadScene(sceneNumber);
        }
        #else
        // compile only for unity 4.6 and older
        {
        Application.LoadScene(sceneNumber);
        }
        #endif

    }

    /// <summary>
    /// Load a scene by index number you specify for the
    /// current unity version
    /// </summary>
    public static int SceneCount
    {

        // compile only for unity 5+
        #if (!(UNITY_4_6 || UNITY_4_5 || UNITY_4_3 || UNITY_4_2 || UNITY_4_1 || UNITY_4_0 || UNITY_3_5))
        get
        {
            return SceneManager.sceneCount;
        }
        #else
        // compile only for unity 4.6 and older
        get
        {
        return Application.levelCount;
        }
        #endif

    }

    /// <summary>
    /// quits the game in the appropriate way, depending on whether we're running
    /// in the editor, in a standalone build or a webplayer (these are the only
    /// platforms supported by the 'Quit' method at present)
    /// </summary>
    public static void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        Application.Quit();
        #endif


    }
}