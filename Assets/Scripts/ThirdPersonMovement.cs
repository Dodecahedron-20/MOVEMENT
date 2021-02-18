﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    //all variables are lowercase first, uppercase later words

    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        //currently works for moving forwards.

        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical, 0f).normalized;
        
        
        float vert = 0;

        if (Input.GetKey(KeyCode.Q))
        {
            vert = 1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            vert = -1;
        }

        if (direction.magnitude >= 0.1f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;



            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            var movement = new Vector3(0, 0, vert) * speed * Time.deltaTime;
            controller.Move(movement);


        }

    }


}

