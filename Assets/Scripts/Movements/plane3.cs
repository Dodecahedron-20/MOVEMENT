using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plane3 : MonoBehaviour
{
    [SerializeField]
    private GM gm;

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private Transform playerBody;

    [SerializeField]
    private float banking = 20f;

    [SerializeField]
    private float turn = 0.7f;

    [SerializeField]
    private float rise = 2f;

    private bool moveable = false;



    private void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKeyDown(KeyCode.Space))
      {
        UnFreeze();
        gm.GameStart();
      }


        var rotY = 0f;
        var rotX = 0f;
        var rotZ = 0f;

        var y = 0f;
        var x = 0f;

        if (moveable == true)
        {
          if (Input.GetKey(KeyCode.A))
          {
              //rotY = -turn;
              rotZ = banking;
             // x -= 1f;
          }
          if (Input.GetKey(KeyCode.D))
          {
              rotZ = -banking;

              //rotY = turn;

              //x += 1f;
          }

          if (Input.GetKey(KeyCode.W))
          {
              rotX = -rise;

             y += 1f;
              //updateCounterbalance();
          }
          if (Input.GetKey(KeyCode.S))
          {

              rotX = rise;
            y -= 0.5f;
          }




                  //movement
                  float z = 1;

                  if (Input.GetKey(KeyCode.Space))
                  {
                      z = 2;
                  }

                  // re- stabilisation isn't happening because we're not working in world space, but player space, and 0 is always where the player is facing (or something like that anyways?)
                  playerBody.Rotate(Vector3.up * rotY + Vector3.right * rotX + Vector3.forward * rotZ);






                  Vector3 move = transform.forward * z + transform.up * y + transform.right * x;


                  controller.Move(move * speed * Time.deltaTime);




        }

    }

    public void Freeze()
    {
      moveable = false;
    }

    private void UnFreeze()
    {
      moveable = true;
    }

}
