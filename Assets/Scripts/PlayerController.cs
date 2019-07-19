using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;

    public float speed;
    public float jumpSpeed;
    public float gravity;

    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //checkif on ground
        if(controller.isGrounded)
        {
            //if we are check inputs or rotation/movement
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //move us in that direction
            moveDirection *= speed;

            //jump
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        //gravity
        moveDirection.y -= gravity * Time.deltaTime;
        //move the character
        controller.Move(moveDirection * Time.deltaTime);

    }
}
