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
        var rotZ = 0f;

        var y = 0f;
        var x = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            rotY = -banking;
            rotZ = banking;
            x -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotY = banking;
            rotZ = -banking;
            x += 1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rotX = -banking;
            y -= 0.5f;
        }
        if (Input.GetKey(KeyCode.S))
        {

            rotX = banking;
            y += 0.5f;
        }



        //movement
        float z = 1;

        if (Input.GetKey(KeyCode.Space))
        {
            z = 2;
        }


        playerBody.Rotate(Vector3.up * rotY + Vector3.right * rotX + Vector3.forward * rotZ);



       


        Vector3 move = transform.forward * z + transform.up * y + transform.right * x;


        controller.Move(move * speed * Time.deltaTime);




    }
}
