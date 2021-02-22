using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    [SerializeField]
    private Transform camTarget;

    [SerializeField][Range(0,1)]
    private float followSpeed;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = camTarget.position;

        transform.rotation = Quaternion.Slerp(transform.rotation, camTarget.rotation, followSpeed);

    }
}
