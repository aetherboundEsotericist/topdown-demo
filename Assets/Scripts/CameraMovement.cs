using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Camera movement script that follows a target object.
    Uses lerp for smooth movement
*/

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 camMinPos; // min and max pos values are updated by the GameHandler object
    public Vector2 camMaxPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            // targetPosition takes the target's X and Y, but keeps it's own Z
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, camMinPos.x, camMaxPos.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, camMinPos.y, camMaxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}