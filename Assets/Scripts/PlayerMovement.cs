using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
    Simple topdown 2D movement script with normalized diagonal speed.
    It's a generic class with little requirements, ready to be dragged and dropped into the player object.
    Required Components: Rigidbody2D 
*/

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D playerRB;
    private float inputHorizontal;
    private float inputVertical;
    private Vector2 lastDirection;
    private Animator animator;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //Movement section
        //If the player has a directional input
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            playerRB.velocity = new Vector2(inputHorizontal, inputVertical) * moveSpeed * Time.deltaTime;
            lastDirection = new Vector2(inputHorizontal, inputVertical); 
            //animator.SetBool("isMoving", true);
        }
        //Else just stay still
        else
        {
            playerRB.velocity = new Vector2(0f, 0f); // This will force the player's velocity to 0 when there's no input. Works for movement, but should be reworked if anything else tries to move the player.
            //animator.SetBool("isMoving", false);
        }

        //Set the sprite's direction
        //animator.SetFloat("moveX", lastDirection.x);
        //animator.SetFloat("moveY", lastDirection.y);
        


        //Debug.Log(lastDirection);
    }
}
