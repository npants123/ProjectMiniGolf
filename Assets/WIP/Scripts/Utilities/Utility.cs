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
}
