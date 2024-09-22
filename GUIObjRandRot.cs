using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomRotateObj))]
public class GUIObjRandRot : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GUILayout.Label("Random rotate objects");
        RandomRotateObj randScript = (RandomRotateObj)target;
        if (GUILayout.Button("Random rotate"))
        {
            randScript.RotateRandom();
        }

    }
}
