using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject activeScreen;
    public GameObject newActiveScreen;
    public CameraMovement mainCameraRef;

    void Start()
    {
        mainCameraRef = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activeScreen != newActiveScreen) //screen changed, lets update
        {
            Debug.Log("screen changed, updating");
            activeScreen = newActiveScreen;
            mainCameraRef.camMinPos = activeScreen.transform.Find("Min Pos").transform.position;
            Debug.Log("found value is " + mainCameraRef.camMinPos);

            mainCameraRef.camMaxPos = activeScreen.transform.Find("Max Pos").transform.position;
            Debug.Log("found value is " + mainCameraRef.camMaxPos);
        }
    }
}
