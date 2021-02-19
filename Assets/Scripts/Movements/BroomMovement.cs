using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomMovement : MonoBehaviour
{

    [SerializeField]
    private float Speed;

    //All KeyCodes
    //[SerializeField]
    //private KeyCode GoForward;
    [SerializeField]
    private KeyCode Left;
    [SerializeField]
    private KeyCode Right;
    [SerializeField]
    private KeyCode Up;
    [SerializeField]
    private KeyCode Down;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var side = 0;       
        var vert = 0;
        var forward = 0;


        //moving on x
        if (Input.GetKey(Left))
        {
            side -= 1;
        }
        if (Input.GetKey(Right))
        {
            side += 1;
        }


        //moving on y
        if (Input.GetKey(Up))
        {
            vert += 1;
        }
        if (Input.GetKey(Down))
        {
            vert -= 1;
        }



       
        forward += 1;

        var movement = new Vector3(side, vert, forward).normalized * Speed * Time.deltaTime;
        transform.position += movement;

    }

    private void addSpeed()
    {

    }





}
