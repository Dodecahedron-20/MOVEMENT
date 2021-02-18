using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 6;

    private Vector3 position = new Vector3(0, 1, 0);






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //var vert = 0;
        //var horiz = 0;


        var movement = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movement;



    }
}
