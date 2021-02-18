using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeControl : MonoBehaviour
{
    [SerializeField]
    private float BaseSpeed = 20;
    [SerializeField]
    private float ForwardSpeed = 1;

    private float speed = 20;

    private float BurstSpeed = 80;

    [SerializeField]
    private float burst = 0.5f;

    private bool BurstAvailable = true;
    [SerializeField]
    private int burstoffline = 4;

    private Vector3 position = new Vector3(0, 1, 0);

    [SerializeField]
    private float banking = 20;
    [SerializeField]
    private float rise = 20;
    [SerializeField]
    private float turn = 20;

    [SerializeField]
    private float RotSmoothTime = 0.1f;

    private float RotSmoothVelocityZ;
    private float RotSmoothVelocityX;
    private float RotSmoothVelocityY;

    void start()
    {
      speed = BaseSpeed;
    }



    // Update is called once per frame
    void Update()
    {


        var vert = 0f;
        var horiz = 0f;
        var go = ForwardSpeed;

        var RotX = 0f;
        var RotY = 0f;
        var RotZ = 0f;


        //horizontal movement
        if (Input.GetKey(KeyCode.A))
        {
            horiz -= 1;
            RotZ = -banking;
            RotY = -turn;
        }

        if (Input.GetKey(KeyCode.D))
        {
            horiz += 1;
            RotZ = banking;
            RotY = turn;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vert += 1;
            RotX = -rise;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vert -= 1.5f;
            RotX = rise;
        }

        //add more to the speed for a short period
        if (Input.GetKeyDown(KeyCode.Space) && BurstAvailable == true)
        {

          SpeedBurst();
          StartCoroutine(SpeedBurstTimer());

        }




        var movement = new Vector3(horiz, vert, go) * speed * Time.deltaTime;
        transform.position += movement;

        float SmoothRotZ = Mathf.SmoothDampAngle(transform.eulerAngles.z, RotZ, ref RotSmoothVelocityZ, RotSmoothTime);
        float SmoothRotX = Mathf.SmoothDampAngle(transform.eulerAngles.x, RotX, ref RotSmoothVelocityX, RotSmoothTime);
        float SmoothRotY = Mathf.SmoothDampAngle(transform.eulerAngles.y, RotY, ref RotSmoothVelocityY, RotSmoothTime);



        transform.rotation = Quaternion.Euler(SmoothRotX, SmoothRotY, SmoothRotZ);
    }

private void SpeedBurst()
{
  speed = BurstSpeed;
  BurstAvailable = false;
}


IEnumerator SpeedBurstTimer()
{
 yield return new WaitForSeconds(burst);
SpeedBurstOver();

}

private void SpeedBurstOver()
{
  speed = BaseSpeed;
  StartCoroutine(BurstBackTimer());

}

IEnumerator BurstBackTimer()
{

 yield return new WaitForSeconds(burstoffline);

BurstAvailable = true;

}




}
