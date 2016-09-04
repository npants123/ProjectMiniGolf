using System.Collections;
using UnityEngine;

/// <summary>
/// Take screenshot.
/// </summary>
public class TakeScreenshot : MonoBehaviour
{

    /// <summary>
    /// The screen nom.
    /// </summary>
    public int screenNom = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string fn = Application.dataPath;
            fn = fn.Substring(0, fn.Length - 6);
            int index = screenNom;

            //fn += Application.loadedLevelName + index.ToString() + ".png";
            fn += Gameplay.CurrentSceneName + index.ToString() + ".png";
            Debug.Log("captureScreenshot:" + fn);
            Application.CaptureScreenshot(fn);
            screenNom++;
        }
    }
}
