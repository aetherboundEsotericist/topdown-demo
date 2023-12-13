using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is the script that changes what screen is the active one. All screens have it
public class ScreenTransition : MonoBehaviour
{
    [SerializeField] GameHandler gameHandlerRef; //reference to the Game Handler script
    Rigidbody2D screenBoundary; //this object's 2D RB is the screen boundary 
    void Start()
    {
        gameHandlerRef = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameHandler>();
        screenBoundary = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        gameHandlerRef.newActiveScreen = this.gameObject;
        Debug.Log(col.gameObject.name);

    }
    // when player collides -> if currentscreenID != thisscreenID -> currentscreenID = thisscreenID
}
