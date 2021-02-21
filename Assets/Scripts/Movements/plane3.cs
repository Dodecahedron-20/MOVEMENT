using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plane3 : MonoBehaviour
{

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private Transform playerBody;

    //rotation stabilization testing goes here:
    //[SerializeField]
    //private Transform basestate;

    [SerializeField]
    private GameObject Testing;

    private float counterbalanceX = 0f;

    //testing some text for the counterbalance stuff goes here:
    [SerializeField]
    private Text CounterbalanceText;

    private void Start()
    {
      Testing.SetActive(false);

    }

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

            y -= 1f;
            updateCounterbalance();
        }
        if (Input.GetKey(KeyCode.S))
        {

            rotX = banking;
            y += 0.5f;
        }

        //more stabililzation testing here


        if (Input.GetKeyUp(KeyCode.W))
        {
          Testing.SetActive(true);

             rotX = +counterbalanceX;
             counterbalanceX = 0;

        }

        //stabilizatin testing ends here (for now)


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

private void updateCounterbalance()
{
  counterbalanceX = counterbalanceX + 0.1f;
  CounterbalanceText.text = "counterX: " + counterbalanceX;

}
//oh yeah (((?????????????)))





}
