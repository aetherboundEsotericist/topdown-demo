using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelScript))]
public class EditorScriptingTest : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        LevelScript myLevelScript = (LevelScript)target; 
        myLevelScript.experience = EditorGUILayout.IntField("Experience", myLevelScript.experience);
        EditorGUILayout.LabelField("Level", myLevelScript.Level.ToString());
        EditorGUILayout.LabelField("Experience to Level Up", myLevelScript.experienceTolevelUp.ToString());
    }
}