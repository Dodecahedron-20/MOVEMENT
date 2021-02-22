using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{

    [SerializeField]
    private GameObject testCube = null;
    [SerializeField]
    private GM gm;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Boom 1");
        testCube.SetActive(true);
        gm.Damage();
    }


}
