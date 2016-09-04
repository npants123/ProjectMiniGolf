using System.Collections;
using UnityEngine;

// compile only for unity 5+
#if (!(UNITY_4_6 || UNITY_4_5 || UNITY_4_3 || UNITY_4_2 || UNITY_4_1 || UNITY_4_0 || UNITY_3_5))
using UnityEngine.SceneManagement;
#endif

public static class Utility
{

    /// <summary>
    /// shows or hides the mouse cursor in a way suitable for the
    /// current unity version
    /// </summary>
    public static bool LockCursor
    {

            // compile only for unity 5+
            #if (!(UNITY_4_6 || UNITY_4_5 || UNITY_4_3 || UNITY_4_2 || UNITY_4_1 || UNITY_4_0 || UNITY_3_5))
        get
        {
            return ((Cursor.lockState == CursorLockMode.Locked) ? true : false);
        }
        set
        {
            // toggling cursor visible and invisible is currently buggy in the Unity 5
            // editor so we need to toggle brute force with custom arrow art
            #if UNITY_EDITOR
            //Cursor.SetCursor((value ? InvisibleCursor : VisibleCursor), Vector2.zero, CursorMode.Auto);
            //Cursor.visible = value ? InvisibleCursor : VisibleCursor;
            Cursor.visible = !value;
            #else
            // running in a build so toggling visibility should work fine
            Cursor.visible = !value;
            #endif
            Cursor.lockState = (value ? CursorLockMode.Locked : CursorLockMode.None);
        }
            #else
            // compile only for unity 4.6 and older
            get { return Screen.lockCursor; }
            set { Screen.lockCursor = value; }
            #endif

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
        Debug.Log("Quit App");
        #elif UNITY_STANDALONE
        Application.Quit();
        #endif


    }
}
