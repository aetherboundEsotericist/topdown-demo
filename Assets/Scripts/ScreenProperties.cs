using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

// Script used to set the screen bounding box. This is read by the camera to determine how far it can move.
public class ScreenProperties : MonoBehaviour
{
    public int screenID;
    [ReadOnly] public float minY;
    [ReadOnly] public float minX;
    [ReadOnly] public float maxY;
    [ReadOnly] public float maxX;
    public bool isActive;

    // Each screen should contain a Min Pos and a Max Pos object
    // These objects can be moved in the editor to set the boundaries for each screen.
    public Transform minPos;
    public Transform maxPos;

    void Update()
    {
        if(minPos && maxPos)
        {
            minY = minPos.position.y;
            maxY = maxPos.position.y;
            minX = minPos.position.x;
            maxX = maxPos.position.x;  
        }
        else Debug.Log("minPos and maxPos values not set for this object! (" + gameObject.name + ")");
    }
}
