using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    [SerializeField]
    private GM gm;

    private int collectedStars = 0;

  public void StarAdd()
    {
        collectedStars++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collectedStars > 1)
        {
            gm.WinGame();
        }
        

    }




}
