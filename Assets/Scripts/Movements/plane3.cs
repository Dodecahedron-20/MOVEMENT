using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane3 : MonoBehaviour
{

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private Transform playerBody;

    

    // Update is called once per frame
    void Update()
    {
        float banking = 0.1f;

        var rotY = 0f;
        var rotX = 0f;

        var y = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            rotY -= banking;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotY += banking;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rotX -= banking;
            y -= 0.5f;
        }
        if (Input.GetKey(KeyCode.S))
        {

            rotX += banking;
            y += 0.5f;
        }

        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    rotX = 0;
        //}
        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    rotX = 0;
        //}

        // transform.rotation = Quaternion.Euler(0, rotY, 0);


        playerBody.Rotate(Vector3.up * rotY + Vector3.right * rotX);

        float z = 1;

        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");


        Vector3 move = transform.forward * z;


        controller.Move(move * speed * Time.deltaTime);




    }
}
