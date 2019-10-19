using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    [SerializeField] float X;
    [SerializeField] float Y;

    public float Sensitivity = 250;

    Rigidbody thisRigid;

    void Awake()
    {
        thisRigid = gameObject.GetComponent<Rigidbody>();
        Vector3 euler = transform.rotation.eulerAngles;
        X = euler.x;
        Y = euler.y;
        //thisRigid.freezeRotation = true;
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        const float MIN_X = 0.0f;
        const float MAX_X = 360.0f;
        const float MIN_Y = -90.0f;
        const float MAX_Y = 90.0f;

        X += Input.GetAxis("Mouse X") * (Sensitivity * Time.deltaTime);
        if (X < MIN_X) X += MAX_X;
        else if (X > MAX_X) X -= MAX_X;
        Y -= Input.GetAxis("Mouse Y") * (Sensitivity * Time.deltaTime);
        if (Y < MIN_Y) Y = MIN_Y;
        else if (Y > MAX_Y) Y = MAX_Y;

        transform.rotation = Quaternion.Euler(Y, X, 0.0f);

        //if (Input.GetKey(KeyCode.S)) {
          //  if (Y < 15) Y = 12;
          //  else if (Y > 15) Y = 12;
          //  else { }

       // }
    }
}

