using UnityEngine;
using System.Collections;

public class MiniGolfManager : MonoBehaviour
{

    public string GameKeyVersion = "Alpha_Version_0.1";

    void Awake()
    {
        // Controllers
        MiniGolf.gameScript = (GameScript)GameObject.FindObjectOfType(typeof(GameScript));
        MiniGolf.courceController = (CourceController)GameObject.FindObjectOfType(typeof(CourceController));

        // Cameras
        MiniGolf.initCamera = (InitCamera)GameObject.FindObjectOfType(typeof(InitCamera));
        MiniGolf.rollCamera = (RollCamera)GameObject.FindObjectOfType(typeof(RollCamera));
        MiniGolf.waterCamera = (WaterCamera)GameObject.FindObjectOfType(typeof(WaterCamera));
        MiniGolf.aimCamera = (AimCamera)GameObject.FindObjectOfType(typeof(AimCamera));
        MiniGolf.birdsEyeCamera = (BirdsEyeCamera)GameObject.FindObjectOfType(typeof(BirdsEyeCamera));

        // Others
        MiniGolf.GameKeyVersion = GameKeyVersion;
    }
}

public static class MiniGolf
{
    // Controller
    public static GameScript gameScript;
    public static CourceController courceController;

    // Cameras
    public static InitCamera initCamera;
    public static RollCamera rollCamera;
    public static WaterCamera waterCamera;
    public static AimCamera aimCamera;
    public static BirdsEyeCamera birdsEyeCamera;

    // Others
    public static string GameKeyVersion = "";
    public static bool IsOnline = false;

}