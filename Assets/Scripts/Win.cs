using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    [SerializeField]
    private GM gm;

    [SerializeField]
    private int requiredStars = 6;

    private int collectedStars = 0;

  public void StarAdd()
    {
        collectedStars++;

    }

    private void CheckStars()
    {
      if (collectedStars > requiredStars)
      {
        gm.CanWin();
      }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collectedStars > requiredStars)
        {
            gm.WinGame();
        }


    }




}
