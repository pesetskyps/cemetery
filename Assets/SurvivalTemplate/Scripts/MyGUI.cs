using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {
    public GUISkin MySkin;

    void Update()
    {
        GUILayout.Label("label");
    }
    void OnGUI()
    {
        GUI.skin = MySkin;
        GUILayout.BeginArea(new Rect(50, 50, 400, Screen.width / 2));
        GUILayout.BeginHorizontal();
        GUILayout.Label("label");
        GUILayout.Button("buuton");
        GUILayout.EndHorizontal();
        GUILayout.EndHorizontal();
    }
}
