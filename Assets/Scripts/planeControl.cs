using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 6;
    [SerializeField]
    private float ForwardSpeed = 1;

    private Vector3 position = new Vector3(0, 1, 0);

    [SerializeField]
    private float banking = 20;
    [SerializeField]
    private float rise = 20;


    [SerializeField]
    private float RotSmoothTime = 0.1f;
    private float RotSmoothVelocityZ;
    private float RotSmoothVelocityX;



    // Update is called once per frame
    void Update()
    {
        

        var vert = 0;
        var horiz = 0;
        var go = ForwardSpeed;

        var RotX = 0f;
        var RotY = 0f;
        var RotZ = 0f;


        //horizontal movement
        if (Input.GetKey(KeyCode.A))
        {
            horiz -= 1;
            RotZ = -banking;
        }

        if (Input.GetKey(KeyCode.D))
        {
            horiz += 1;
            RotZ = banking;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vert += 1;
            RotX = -rise;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vert -= 2;
            RotX = rise;
        }


        var movement = new Vector3(horiz, vert, go) * speed * Time.deltaTime;
        transform.position += movement;

        float SmoothRotZ = Mathf.SmoothDampAngle(transform.eulerAngles.z, RotZ, ref RotSmoothVelocityZ, RotSmoothTime);
        float SmoothRotX = Mathf.SmoothDampAngle(transform.eulerAngles.x, RotX, ref RotSmoothVelocityX, RotSmoothTime);



        transform.rotation = Quaternion.Euler(SmoothRotX, RotY, SmoothRotZ);
    }
}
