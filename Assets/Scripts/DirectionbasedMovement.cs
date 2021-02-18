using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionbasedMovement : MonoBehaviour
{

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private float speed = 6;

    //[SerializeField]
    //private float turnSmoothTime = 0.1f;

    //private float turnSmoothVelocityFlat;
    //private float turnSmoothVelocityUp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        float forwards = 1;
        //forwards += 1;

        //var movement = new Vector3(0, 0, forwards) * speed * Time.deltaTime;
        //controller.Move(movement);
        Vector3 direction = new Vector3(horizontal, vertical, forwards).normalized;

        if (direction.magnitude >= 0.1)
        {
           //float targetAngleFlat = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
           //float targetAngleUp = Mathf.Atan2(direction.y, direction.z) * Mathf.Rad2Deg;
           // float targetAngleFront = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
           // float angleFlat = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngleFlat, ref turnSmoothVelocityFlat, turnSmoothTime);


           // //float actualAngleUp = targetAngleFlat;
           // //float angleUp = Mathf.SmoothDampAngle(transform.eulerAngles.z, targetAngleUp, ref turnSmoothVelocityUp, turnSmoothTime);
           //transform.rotation = Quaternion.Euler(targetAngleUp, angleFlat, targetAngleFront);


            controller.Move(direction * speed * Time.deltaTime);
        }


    }
}
