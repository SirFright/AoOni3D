using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movControl : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody thisRigid;

    float jumpForce = 175f;
    public float movementSpeed = 5f;

    float newPosX;
    void Start()
    {
    thisRigid = gameObject.GetComponent<Rigidbody>();
    //thisRigid.freezeRotation = true;
    

    }

    void FixedUpdate()
    {
        checkRun();
        checkMovement();
    }

    void checkRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = 8;
        }else if(Input.GetKeyDown(KeyCode.LeftShift) == false)
        {
            movementSpeed = 5;
        }
    }

    void checkMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            thisRigid.MovePosition(transform.position += transform.forward * movementSpeed * Time.deltaTime);
           // transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }

       
    }

    void lostCalls() {

        // newPosX = transform.position.x + 0.5f;
        // thisRigid.AddForce(transform.forward * movementSpeed);
        //if (transform.position.x != newPosX) {

        //
        //   transform.position = new Vector3(newPosX, transform.position.y, transform.position.z);
        //  thisRigid.MovePosition(transform.position + transform.right * Time.deltaTime);
        // }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //canJump = false;
        //    thisRigid.AddForce(transform.up * jumpForce);

        //}
    }
}
