using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IntegrationHelperEditor : EditorWindow
{

    private BuildTargetGroup[] allTargets;
    private Vector2 scrollPos = new Vector2();
    private Color grayishColor;

    [MenuItem("Tools/Mini Golf/Integrations", false, 0)]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<IntegrationHelperEditor>(true, "Integrations", true);
    }

    public void OnEnable()
    {
        allTargets = new BuildTargetGroup[]
        {
            BuildTargetGroup.Standalone,
            BuildTargetGroup.WebPlayer,
            BuildTargetGroup.iOS,
            BuildTargetGroup.PS3,
            BuildTargetGroup.XBOX360,
            BuildTargetGroup.Android,
            //BuildTargetGroup.GLESEmu,
            BuildTargetGroup.WebGL,
            BuildTargetGroup.WSA,
            BuildTargetGroup.WP8,
            BuildTargetGroup.BlackBerry,
            BuildTargetGroup.Tizen,
            BuildTargetGroup.PSP2,
            BuildTargetGroup.PS4,
            BuildTargetGroup.PSM,
            BuildTargetGroup.XboxOne,
            BuildTargetGroup.SamsungTV
        };

        grayishColor = new Color(0.7f, 0.7f, 0.7f, 1.0f);

    }


    public void OnGUI()
    {
        scrollPos = GUILayout.BeginScrollView(scrollPos);

        ShowIntegration("UNITY CROSS PLATFORM INPUT", "This will alow you to use computer input on a computer and touch on mobile. It a Standered Asset Pack", "https://www.assetstore.unity3d.com/en/#!/content/32351", "CROSS_PLATFORM_INPUT");
        ShowIntegration("PHOTON", "Enable this to turn this game into a multiplayer game", "https://www.assetstore.unity3d.com/en/#!/content/1786", "PHOTON_MULTIPLAYER");

        GUILayout.EndScrollView();

    }

    private void ShowIntegration(string name, string description, string link, string defineName, bool showBox = true)
    {
        if (showBox)
            //EditorGUILayout.BeginVertical(InventoryEditorStyles.boxStyle);
            EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Toggle(IsEnabled(defineName), name))
        {
            EnableIntegration(defineName);
        }
        else
        {
            DisableIntegration(defineName);
        }
        if (GUILayout.Button("View in Asset store", EditorStyles.toolbarButton))
            Application.OpenURL(link);

        EditorGUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUI.color = grayishColor;
        //EditorGUILayout.LabelField(description, InventoryEditorStyles.labelStyle);
        EditorGUILayout.LabelField(description);
        GUI.color = Color.white;

        if (showBox)
            EditorGUILayout.EndVertical();

        GUILayout.Space(10);
    }

    private bool IsEnabled(string name)
    {
        return PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone).Contains(name);
    }

    private void DisableIntegration(string name)
    {
        if (IsEnabled(name) == false) // Already disabled
                return;

        foreach (var target in allTargets)
        {
            string symbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(target);
            string[] items = symbols.Split(';');
            var l = new List<string>(items);
            l.Remove(name);

            PlayerSettings.SetScriptingDefineSymbolsForGroup(target, string.Join(";", l.ToArray()));
        }
    }

    private void EnableIntegration(string name)
    {
        if (IsEnabled(name)) // Already enabled
                return;

        foreach (var target in allTargets)
        {
            string symbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(target);
            string[] items = symbols.Split(';');
            var l = new List<string>(items);
            l.Add(name);

            PlayerSettings.SetScriptingDefineSymbolsForGroup(target, string.Join(";", l.ToArray()));
        }
    }
}
